using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LED_CS_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PortRefresh();
            cmdClose.Enabled = false;
            
        }

        private void PortRefresh()
        {
            cboPorts.Items.Clear();
            cboPorts.Items.AddRange(SerialPort.GetPortNames());

        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if (cboPorts.SelectedIndex == -1)  // Nothing selected
            {
                lblStatus.Text = "No Port selected";
            }
            else
            {

                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cboPorts.SelectedItem.ToString();
                    try
                    {
                        serialPort1.Open(); //Open serial port connection
                        lblStatus.Text = "Serial Connection Established";
                        cmdOpen.Enabled = false;
                        cmdClose.Enabled = true;
                        
                    }
                    catch (System.UnauthorizedAccessException)
                    {
                        lblStatus.Text = "COM Port is open in another appilcation";
                    }


                }
                else
                {
                    lblStatus.Text = "Serial Connection Open";
                    MessageBox.Show("Attention serial Port is open");
                }
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            lblStatus.Text = "Serial Port Closed";
            cmdOpen.Enabled = true;
            cmdClose.Enabled = false;
        }

        private void cmdExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cckOnOffLED_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblBrightnessValue_Click(object sender, EventArgs e)
        {
            
        }
    }
}
