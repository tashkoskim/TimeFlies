
namespace TimeFlies.Clocks
{
    partial class Clock_Morse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_Morse));
            this.lblMorse = new System.Windows.Forms.Label();
            this.lblDigital = new System.Windows.Forms.Label();
            this.timerMorse = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMorse
            // 
            this.lblMorse.AutoSize = true;
            this.lblMorse.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMorse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMorse.Location = new System.Drawing.Point(12, 74);
            this.lblMorse.Name = "lblMorse";
            this.lblMorse.Size = new System.Drawing.Size(354, 32);
            this.lblMorse.TabIndex = 0;
            this.lblMorse.Text = "----- ----- / ----- ----- / ----- -----";
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(320, 176);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 18;
            this.lblDigital.Text = "00:00:00";
            // 
            // timerMorse
            // 
            this.timerMorse.Enabled = true;
            this.timerMorse.Interval = 1000;
            this.timerMorse.Tick += new System.EventHandler(this.timerMorse_Tick);
            // 
            // Clock_Morse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(412, 210);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.lblMorse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_Morse";
            this.Text = "Morse clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMorse;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timerMorse;
    }
}