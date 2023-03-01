
namespace TimeFlies.Clocks
{
    partial class Clock_Hexa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_Hexa));
            this.lblHexTime = new System.Windows.Forms.Label();
            this.lblDigital = new System.Windows.Forms.Label();
            this.timerHex = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHexTime
            // 
            this.lblHexTime.AutoSize = true;
            this.lblHexTime.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHexTime.ForeColor = System.Drawing.Color.White;
            this.lblHexTime.Location = new System.Drawing.Point(48, 63);
            this.lblHexTime.Name = "lblHexTime";
            this.lblHexTime.Size = new System.Drawing.Size(294, 89);
            this.lblHexTime.TabIndex = 0;
            this.lblHexTime.Text = "#000000";
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(297, 207);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 16;
            this.lblDigital.Text = "00:00:00";
            // 
            // timerHex
            // 
            this.timerHex.Enabled = true;
            this.timerHex.Interval = 1000;
            this.timerHex.Tick += new System.EventHandler(this.timerHex_Tick);
            // 
            // Clock_Hexa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 241);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.lblHexTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_Hexa";
            this.Text = "Hexadecimal clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHexTime;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timerHex;
    }
}