using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    status.Text = m_portC.getDevErrorDesc();
                    break;
                case ReloadController.DeviceStatus.DEV_STATUS_OVERTEMP:
                    status.Text = "Overtemperature!!";
                    break;
                case ReloadController.DeviceStatus.DEV_STATUS_UNDERVOLT:
                    status.Text = "UnderVolt!!";
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
                    numSetCurrent.Value = response;
                }
                lastSetCurrent = (decimal) response / 1000M;
            }
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
            numSetCurrent.Value -= .010M;
        }

        private void btnInc100_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value += .100M;
        }

        private void btnDec100_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value -= .100M;
        }

        private void btnInc1000_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value += 1M;
        }

        private void btnDec1000_Click(object sender, EventArgs e)
        {
            numSetCurrent.Value -= 1M;
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
            showCurrentVoltage();
        }

        private void showCurrentVoltage()
        {
            m_portC.updateCurrentVoltage();
            lblCurrent.Text = formatNumber(m_portC.getCurrent(), "A");
            lblVolt.Text = formatNumber(m_portC.getVoltage(), "V");
            lblPower.Text = formatNumber(m_portC.getPower(), "W");
        }

        private string formatNumber(int number, string sufix)
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

       

      

      
    
      

    

        
    }
}
