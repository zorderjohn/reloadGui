using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReloadGUI
{
    public partial class frmMain : Form
    {
        private const int autoSetTime = 10;
        private ReloadController m_portC;
        private decimal lastSetCurrent = 0;
        private int autoSetCount = 0;

        public frmMain()
        {
            InitializeComponent();
            m_portC = new ReloadController();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbPort.Items.AddRange(m_portC.scanComPorts());
            if (cmbPort.Items.Count > 0)
            {
                cmbPort.SelectedIndex = 0;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (m_portC.isConnected())
            {
                if (m_portC.disconnect())
                {
                    status.Text = "Disconnected";
                    btnConnect.Text = "Connect";
                    grpControlPanel.Enabled = false;
                }
            } else if (m_portC.connect(cmbPort.SelectedItem.ToString()))
            {
                btnConnect.Text = "Disconnect";
                status.Text = "Connected to " + cmbPort.SelectedItem.ToString();
                onConnect();
                grpControlPanel.Enabled = true;
            }
        }

        private void onConnect()
        {
            string version = m_portC.getVersion();
            if (version != "")
            {
                lblVersion.Text = version;
                updateMonitorMode();
            }
            else
            {
                manageError();
            }
        }

        private void manageError()
        {
            switch (m_portC.getDevState())
            {
                case ReloadController.DeviceStatus.DEV_STATUS_ERR:
                    status.Text = "Error: " + m_portC.getDevErrorDesc();
                    break;
                case ReloadController.DeviceStatus.DEV_STATUS_OVERTEMP:
                    status.Text = "Overtemperature!!";
                    break;
                case ReloadController.DeviceStatus.DEV_STATUS_UNDERVOLT:
                    status.Text = "UnderVolt!!";
                    break;
                default:
                    status.Text = "Unknown error";
                    break;

            }
        }

        private void numSetCurrent_ValueChanged(object sender, EventArgs e)
        {
            if (chkAutoSet.Checked)
            {
                setCurrent();
            }
            else
            {
                btnSetCurrent.Enabled = true;
            }
        }

        private void btnSetCurrent_Click(object sender, EventArgs e)
        {
            setCurrent();
            btnSetCurrent.Enabled = false;
        }

        private void setCurrent() 
        {
            //tmrMonitor.Enabled = false;
            Debug.Print("set current\n");
            status.Text = "Set current to: " + numSetCurrent.Value.ToString();
            int response = m_portC.setCurrent((int)(numSetCurrent.Value * 1000));

            if (response == -1)
            {
                manageError();
                numSetCurrent.Value = lastSetCurrent;
            }
            else
            {
                if (numSetCurrent.Value * 1000 != response)
                {
                    numSetCurrent.Value = response / 1000M;
                }
                lastSetCurrent = (decimal) response / 1000M;
            }
            tmrMonitor.Enabled = true;
        }

        private void chkAutoSet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSet.Checked)
            {
                btnSetCurrent.Enabled = false;
                setCurrent();
                prgAutoSet.Visible = true;
            }
            else
            {
                prgAutoSet.Visible = false;
            }
        }

        private void btnInc10_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value += .010M;
        }

        private void btnDec10_Click(object sender, EventArgs e)
        {
            if (numSetCurrent.Value >= .010M)
            {
                numSetCurrent.Value -= .010M;
            }
            else
            {
                numSetCurrent.Value = 0M;
            }
        }

        private void btnInc100_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value += .100M;
        }

        private void btnDec100_Click(object sender, EventArgs e)
        {
            if (numSetCurrent.Value >= .100M)
            {
                numSetCurrent.Value -= .100M;
            }
            else
            {
                numSetCurrent.Value = 0M;
            }
        }

        private void btnInc1000_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value += 1M;

        }

        private void btnDec1000_Click(object sender, EventArgs e)
        {
            if (numSetCurrent.Value >= 1M)
            {
                numSetCurrent.Value -= 1M;
            }
            else
            {
                numSetCurrent.Value = 0M;
            }
        }

        private void numSetCurrent_KeyDown(object sender, KeyEventArgs e)
        {
            if (chkAutoSet.Checked)
            {
                tmrAutoSet.Enabled = true;
                autoSetCount = 0;
            }
        }

        private void tmrAutoSet_Tick(object sender, EventArgs e)
        {
            autoSetCount++;
            if (autoSetCount > autoSetTime)
            {
                setCurrent();
                autoSetCount = 0;
                tmrAutoSet.Enabled = false;
            }
            prgAutoSet.Value = autoSetCount;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            showCurrentVoltage();
        }

        private void tmrMonitor_Tick(object sender, EventArgs e)
        {
           // Debug.Print("tick\n");
            showCurrentVoltage();
        }

        private void showCurrentVoltage()
        {
            if (chkMonitor.Enabled)
            {
                m_portC.updateCurrentVoltage();
            }
            else
            {
                m_portC.requestUpdate();
            }

            lblCurrent.Text = formatNumber(m_portC.getCurrent(), "A");
            lblVolt.Text = formatNumber(m_portC.getVoltage(), "V");
            lblPower.Text = formatNumber(m_portC.getPower(), "W");

            addGraphData(m_portC.getVoltage(), m_portC.getCurrent(), (float)numSetCurrent.Value);
        }

        void addGraphData(float volt, float current, float setCurrent)
        {
            if (chartTime.Series[0].Points.Count > 100)
            {
                chartTime.Series[0].Points.RemoveAt(0);
                chartTime.Series[1].Points.RemoveAt(0);
                chartTime.Series[2].Points.RemoveAt(0);

            }

            chartTime.Series[0].Points.Add(volt*0.001f);
            chartTime.Series[1].Points.Add(current*0.001f);
            chartTime.Series[2].Points.Add(setCurrent);

            double maxVolt = chartTime.Series[0].Points.FindMaxByValue().YValues[0];
            double maxInt = chartTime.Series[2].Points.FindMaxByValue().YValues[0];
            
            chartTime.ChartAreas[0].AxisY.Maximum = getScale(maxVolt);
            chartTime.ChartAreas[0].AxisY2.Maximum = getScale(maxInt);
            
        }

        double getScale(double value) {
            double value1 = Math.Ceiling((value * 5d) / 5d);
            
            double value2 = Math.Max(0.2d, value1 * 5d * 0.2d);
            return value2;
        }

        private string formatNumber(float number, string sufix)
        {
            float fNumber = number/1000f;
            return String.Format("{0:0.000}", fNumber) + " " + sufix;
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            updateMonitorMode();
        }

        void updateMonitorMode()
        {
            tmrMonitor.Interval = (int)(numMonitorInterval.Value *.5M);
            tmrMonitor.Enabled = chkMonitor.Checked;
            btnRead.Enabled = !chkMonitor.Checked;

            if (chkMonitor.Checked)
            {
                if (!m_portC.setMonitorMode((int) numMonitorInterval.Value))
                    manageError();
            }
            else
            {
                if (!m_portC.setMonitorMode(0))
                    manageError();
            }
        }

        private void numMonitorInterval_ValueChanged(object sender, EventArgs e)
        {
            updateMonitorMode();
        }

        private void btnBootloader_Click(object sender, EventArgs e)
        {
            if (m_portC.setBootloaderMode())
            {
                m_portC.disconnect();
                status.Text = "Disconnected";
                btnConnect.Text = "Connect";
                btnConnect.Enabled = false;
                grpControlPanel.Enabled = false;
                tmrMonitor.Enabled = false;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value = 0M;
        }

        private void tmrSetCurrent_Tick(object sender, EventArgs e)
        {
            if (chkAutoSet.Checked)
            {
                float deviceSetCurrent = m_portC.getSetCurrent() / 1000f;
                if (numSetCurrent.Value != (decimal)deviceSetCurrent)
                {
                    numSetCurrent.Value = (decimal)deviceSetCurrent;
                }
            }

        }

       

      

      
    
      

    

        
    }
}
