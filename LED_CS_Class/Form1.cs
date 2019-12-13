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
            cckOnOffLED.Enabled = false;

            while(true)
            {
                if(serialPort1.IsOpen && cckOnOffLED.Checked)
                {
                    refreshData();
                }
            }
            
        }

        public void refreshData()
        {
            string value = serialPort1.ReadLine();
            lblBrightnessValue.Text = value;
            System.Threading.Thread.Sleep(100);
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
                        cckOnOffLED.Enabled = true;
                        
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
            if(cckOnOffLED.Checked)
            {
                gboLEDControll.Visible = true;
                cckOnOffLED.BackColor = Color.Green;
                lblBrightnessValue.Text = "";
                serialPort1.DiscardInBuffer();
                serialPort1.WriteLine("y");
            }
            else if(cckOnOffLED.Checked == false)
            {
                gboLEDControll.Visible = false;
                cckOnOffLED.Text = "LED Off";
                cckOnOffLED.BackColor = Color.Red;
                serialPort1.WriteLine("n");
            }
        }

        private void cmdIncreaseSmall_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("+");
        }

        private void cmdDecreaseSmall_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-");
        }

        private void cmdIncreaseBig_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("++");
        }

        private void cmdDecreaseBig_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("--");
        }
    }

}
