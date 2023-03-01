
namespace TimeFlies.Clocks
{
    partial class Clock_Analog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_Analog));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backBox = new System.Windows.Forms.PictureBox();
            this.hourBox = new System.Windows.Forms.PictureBox();
            this.minuteBox = new System.Windows.Forms.PictureBox();
            this.secondBox = new System.Windows.Forms.PictureBox();
            this.lblDigital = new System.Windows.Forms.Label();
            this.pBoxGlass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backBox
            // 
            this.backBox.BackColor = System.Drawing.Color.Transparent;
            this.backBox.BackgroundImage = global::TimeFlies.Properties.Resources.Analog_clock1;
            this.backBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBox.Location = new System.Drawing.Point(0, 0);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(500, 504);
            this.backBox.TabIndex = 0;
            this.backBox.TabStop = false;
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.Transparent;
            this.hourBox.Location = new System.Drawing.Point(-367, 12);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(500, 504);
            this.hourBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hourBox.TabIndex = 1;
            this.hourBox.TabStop = false;
            // 
            // minuteBox
            // 
            this.minuteBox.BackColor = System.Drawing.Color.Transparent;
            this.minuteBox.Location = new System.Drawing.Point(-335, 30);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(500, 504);
            this.minuteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minuteBox.TabIndex = 2;
            this.minuteBox.TabStop = false;
            // 
            // secondBox
            // 
            this.secondBox.BackColor = System.Drawing.Color.Transparent;
            this.secondBox.Location = new System.Drawing.Point(-274, 59);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(500, 504);
            this.secondBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondBox.TabIndex = 3;
            this.secondBox.TabStop = false;
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(411, 484);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 20;
            this.lblDigital.Text = "00:00:00";
            // 
            // pBoxGlass
            // 
            this.pBoxGlass.BackColor = System.Drawing.Color.Transparent;
            this.pBoxGlass.Location = new System.Drawing.Point(-249, 116);
            this.pBoxGlass.Name = "pBoxGlass";
            this.pBoxGlass.Size = new System.Drawing.Size(500, 504);
            this.pBoxGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxGlass.TabIndex = 21;
            this.pBoxGlass.TabStop = false;
            // 
            // Clock_Analog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(503, 518);
            this.Controls.Add(this.pBoxGlass);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.backBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_Analog";
            this.Text = "Analog clock";
            this.Load += new System.EventHandler(this.Clock_Analog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.PictureBox hourBox;
        private System.Windows.Forms.PictureBox minuteBox;
        private System.Windows.Forms.PictureBox secondBox;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.PictureBox pBoxGlass;
    }
}