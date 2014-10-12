using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ReloadGUI
{
    class ReloadController
    {
        SerialPort sp;
        private static int readTimeout = 50;
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

        private string[] command(string cmd, string expected)
        {
            if (!sp.IsOpen)
            {
                return null;
            }

            sp.WriteLine(cmd);
            string[] response = null;
            try
            {
                response = sp.ReadLine().Split(new char[] { ' ' }, 2);
            }
            catch (TimeoutException t)
            {
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
            }
            else if (response[0] != expected)
            {
                return null;
            }
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

        public int getCurrent() 
        {
            return readCurrent;
        }

        public int getVoltage() 
        {
            return readVoltage;
        }

        public int getPower()
        {
            return readCurrent * readVoltage;
        }

        public void updateCurrentVoltage()
        {
            string[] response = command("read", "read");
            if (response != null && response.Length > 1)
            {
                processReadValues(response[1]);
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
            return command("monitor " + interval.ToString(), "monitor") != null;
        }

        
    }
}
