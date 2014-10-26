using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace ReloadGUI
{
    class ReloadController
    {
        SerialPort sp;
        private static int readTimeout = 100;
        private static int comSpeed = 115200;
        private static int minCurrent = 0;
        private static int maxCurrent = 99000;
        private string errDesc;
        public enum DeviceStatus { DEV_STATUS_DISC, DEV_STATUS_OK, DEV_STATUS_ERR, DEV_STATUS_OVERTEMP, DEV_STATUS_UNDERVOLT };
        private DeviceStatus devStatus;
        int readCurrent = 0;
        int readVoltage = 0;

        
        public ReloadController()
        {
            sp = new SerialPort();
            devStatus = DeviceStatus.DEV_STATUS_DISC;
        }

        public string[] scanComPorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool connect(string portName)
        {
            sp.ReadTimeout = readTimeout;
            if (devStatus == DeviceStatus.DEV_STATUS_DISC)
            {
                sp.PortName = portName;
                sp.BaudRate = comSpeed;
                try
                {
                    sp.Open();
                    devStatus = DeviceStatus.DEV_STATUS_OK;
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isConnected()
        {
            return sp.IsOpen;
        }

        public bool disconnect()
        {
            if (devStatus != DeviceStatus.DEV_STATUS_DISC)
            {
                try
                {
                    sp.Close();
                    devStatus = DeviceStatus.DEV_STATUS_DISC;
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public DeviceStatus getDevState()
        {
            return devStatus;
        }

        public string getVersion()
        {
            string[] response = command("version", "version");
            if (response != null && response.Length > 1)
            {
                return response[1];
            }
            return "";
        }

        private string[] command(string cmd, string expected, int timeout = 200)
        {
            if (!sp.IsOpen)
            {
                return null;
            }
            sp.ReadTimeout = timeout;

            if (cmd != "")
            {
                sp.WriteLine(cmd);
                //Thread.Sleep(20);
            }
            if (expected == "")
            {
                return null;
            }
            string[] response = null;
            bool readAgain;
            int trialsReamaining = 10;
            do
            {
                readAgain = false;
                try
                {
                    response = sp.ReadLine().Split(new char[] { ' ' }, 2);
                    /*if (response.Length > 0)
                        Debug.Print(response[0]);
                    else
                        Debug.Print("RRRRR");*/
                }
                catch (TimeoutException t)
                {
                   // Debug.Print("_");
                    return null;
                }
                if (response == null || response.Length == 0)
                {
                    return null;
                }
                else if (response[0] == "overtemp")
                {
                    devStatus = DeviceStatus.DEV_STATUS_OVERTEMP;
                    return null;
                }
                else if (response[0] == "undervolt")
                {
                    devStatus = DeviceStatus.DEV_STATUS_UNDERVOLT;
                    return null;
                }
                else if (response[0] == "err")
                {
                    devStatus = DeviceStatus.DEV_STATUS_ERR;
                    if (response.Length > 0)
                    {
                        errDesc = response[1];
                    }
                    return null;
                }
                else if (response[0] == "read")
                {
                    
                    if (response.Length > 0)
                    {
                        processReadValues(response[1]);
                    }

                    readAgain = (response[0] != expected && trialsReamaining>0);
                    trialsReamaining--;
                }
                else if (response[0] != expected)
                {
                    return null;
                }
            } while (readAgain);

            return response;                
        }
        private string[] tryRead()
        {
            if (!sp.IsOpen)
            {
                return null;
            }
            sp.ReadTimeout = 5;

            string[] response = null;
            bool readAgain = true;
            do
            {
                try
                {
                    response = sp.ReadLine().Split(new char[] { ' ' }, 2);
                }
                catch (TimeoutException t)
                {
                    return response;
                }
                if (response == null || response.Length == 0)
                {
                    return null;
                }
                else if (response[0] == "overtemp")
                {
                    devStatus = DeviceStatus.DEV_STATUS_OVERTEMP;
                    return null;
                }
                else if (response[0] == "undervolt")
                {
                    devStatus = DeviceStatus.DEV_STATUS_UNDERVOLT;
                    return null;
                }
                else if (response[0] == "err")
                {
                    devStatus = DeviceStatus.DEV_STATUS_ERR;
                    if (response.Length > 0)
                    {
                        errDesc = response[1];
                    }
                    return null;
                }
                else if (response[0] == "read")
                {
                    if (response.Length > 0)
                    {
                        processReadValues(response[1]);
                    }
                    
                }               
            } while (readAgain);

            return response;
        }

        public string getDevErrorDesc()
        {
            return errDesc;
        }

        public int setCurrent(int milliamps)
        {
            milliamps = Math.Min(Math.Max(milliamps, minCurrent), maxCurrent);
            string[] response = command("set " + milliamps.ToString(), "set");
            if (response != null && response.Length > 1)
            {
                int returnValue = 0;
                if (int.TryParse(response[1], out returnValue))
                {
                    return returnValue;
                }
            }            
            return -1;
        }

        public float getCurrent() 
        {
            return readCurrent;
        }

        public float getVoltage() 
        {
            return readVoltage;
        }

        public float getPower()
        {
            return readCurrent * readVoltage * 0.001f;
        }

        //Sends the request to the device and reads the values
        public void requestUpdate()
        {
            string[] response = command("read", "read");
            if (response != null && response.Length > 1)
            {
                if (response[0] == "read")
                {
                    processReadValues(response[1]);
                }
            }
        }

        //Assumes monitor mode enabled, and just tries to read the values
        public void updateCurrentVoltage()
        {
            string[] response = tryRead();
            if (response != null && response.Length > 1)
            {
                if (response[0] == "read")
                {
                    processReadValues(response[1]);
                }
            }
        }
             
        public void processReadValues(string strValues) 
        {
            string[] values = strValues.Split(new char[] { ' ' });
            if (values.Length > 1)
            {
                try{
                    readCurrent = int.Parse(values[0]);
                    readVoltage = int.Parse(values[1]);
                }
                catch(Exception e) {} 
            }
        }

        public bool setMonitorMode(int interval=100)
        {
            command("monitor " + interval.ToString(), "");
            return true;
        }

        public bool setBootloaderMode()
        {
            string[] response = command("bl", "ok");
            return response != null;
        }

        public bool setADCOffset()
        {
            string[] response = command("cal o", "ok");
            return response != null;
        }

        public bool setADCVolt(int voltage)
        {
            if (voltage <= 0)
                return false;

            string[] response = command("cal v " + voltage.ToString(), "ok");
            return response != null;
        }

        public bool setADCCurrent(int current)
        {
            if (current <= 0)
                return false;

            string[] response = command("cal i " + current.ToString(), "ok");
            return response != null;
        }

        public float getSetCurrent()
        {
            string[] response = command("set", "set");
            float result = 0f;

            if (response != null && response.Length > 1)
            {

                if(float.TryParse(response[1], out result))
                {
                    return result;
                }
                
            }
            return result;
        }



        
    }
}
