namespace LED_CS_Class
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdExitApp = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cckOnOffLED = new System.Windows.Forms.CheckBox();
            this.gboLEDControll = new System.Windows.Forms.GroupBox();
            this.cmdIncreaseSmall = new System.Windows.Forms.Button();
            this.cmdDecreaseSmall = new System.Windows.Forms.Button();
            this.cmdIncreaseBig = new System.Windows.Forms.Button();
            this.cmdDecreaseBig = new System.Windows.Forms.Button();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.gboLEDControll.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(114, 207);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 33);
            this.cboPorts.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(109, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(33, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "---";
            // 
            // cmdExitApp
            // 
            this.cmdExitApp.Location = new System.Drawing.Point(553, 300);
            this.cmdExitApp.Name = "cmdExitApp";
            this.cmdExitApp.Size = new System.Drawing.Size(155, 85);
            this.cmdExitApp.TabIndex = 7;
            this.cmdExitApp.Text = "Exit";
            this.cmdExitApp.UseVisualStyleBackColor = true;
            this.cmdExitApp.Click += new System.EventHandler(this.cmdExitApp_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(553, 180);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(155, 85);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(553, 54);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(155, 85);
            this.cmdOpen.TabIndex = 5;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cckOnOffLED
            // 
            this.cckOnOffLED.AutoSize = true;
            this.cckOnOffLED.Location = new System.Drawing.Point(114, 430);
            this.cckOnOffLED.Name = "cckOnOffLED";
            this.cckOnOffLED.Size = new System.Drawing.Size(161, 29);
            this.cckOnOffLED.TabIndex = 10;
            this.cckOnOffLED.Text = "LED ein aus";
            this.cckOnOffLED.UseVisualStyleBackColor = true;
            this.cckOnOffLED.CheckedChanged += new System.EventHandler(this.cckOnOffLED_CheckedChanged);
            // 
            // gboLEDControll
            // 
            this.gboLEDControll.Controls.Add(this.lblBrightnessValue);
            this.gboLEDControll.Controls.Add(this.cmdDecreaseBig);
            this.gboLEDControll.Controls.Add(this.cmdIncreaseBig);
            this.gboLEDControll.Controls.Add(this.cmdDecreaseSmall);
            this.gboLEDControll.Controls.Add(this.cmdIncreaseSmall);
            this.gboLEDControll.Location = new System.Drawing.Point(114, 530);
            this.gboLEDControll.Name = "gboLEDControll";
            this.gboLEDControll.Size = new System.Drawing.Size(493, 346);
            this.gboLEDControll.TabIndex = 11;
            this.gboLEDControll.TabStop = false;
            this.gboLEDControll.Text = "LED Controll";
            // 
            // cmdIncreaseSmall
            // 
            this.cmdIncreaseSmall.Location = new System.Drawing.Point(35, 62);
            this.cmdIncreaseSmall.Name = "cmdIncreaseSmall";
            this.cmdIncreaseSmall.Size = new System.Drawing.Size(91, 52);
            this.cmdIncreaseSmall.TabIndex = 0;
            this.cmdIncreaseSmall.Text = "+";
            this.cmdIncreaseSmall.UseVisualStyleBackColor = true;
            // 
            // cmdDecreaseSmall
            // 
            this.cmdDecreaseSmall.Location = new System.Drawing.Point(191, 62);
            this.cmdDecreaseSmall.Name = "cmdDecreaseSmall";
            this.cmdDecreaseSmall.Size = new System.Drawing.Size(91, 52);
            this.cmdDecreaseSmall.TabIndex = 1;
            this.cmdDecreaseSmall.Text = "-";
            this.cmdDecreaseSmall.UseVisualStyleBackColor = true;
            // 
            // cmdIncreaseBig
            // 
            this.cmdIncreaseBig.Location = new System.Drawing.Point(35, 177);
            this.cmdIncreaseBig.Name = "cmdIncreaseBig";
            this.cmdIncreaseBig.Size = new System.Drawing.Size(91, 52);
            this.cmdIncreaseBig.TabIndex = 2;
            this.cmdIncreaseBig.Text = "++";
            this.cmdIncreaseBig.UseVisualStyleBackColor = true;
            // 
            // cmdDecreaseBig
            // 
            this.cmdDecreaseBig.Location = new System.Drawing.Point(191, 177);
            this.cmdDecreaseBig.Name = "cmdDecreaseBig";
            this.cmdDecreaseBig.Size = new System.Drawing.Size(91, 52);
            this.cmdDecreaseBig.TabIndex = 3;
            this.cmdDecreaseBig.Text = "--";
            this.cmdDecreaseBig.UseVisualStyleBackColor = true;
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoSize = true;
            this.lblBrightnessValue.Location = new System.Drawing.Point(121, 132);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(63, 25);
            this.lblBrightnessValue.TabIndex = 4;
            this.lblBrightnessValue.Text = "Wert:";
            this.lblBrightnessValue.Click += new System.EventHandler(this.lblBrightnessValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 1060);
            this.Controls.Add(this.gboLEDControll);
            this.Controls.Add(this.cckOnOffLED);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdExitApp);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboLEDControll.ResumeLayout(false);
            this.gboLEDControll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdExitApp;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox cckOnOffLED;
        private System.Windows.Forms.GroupBox gboLEDControll;
        private System.Windows.Forms.Button cmdDecreaseBig;
        private System.Windows.Forms.Button cmdIncreaseBig;
        private System.Windows.Forms.Button cmdDecreaseSmall;
        private System.Windows.Forms.Button cmdIncreaseSmall;
        private System.Windows.Forms.Label lblBrightnessValue;
    }
}

