
namespace TimeFlies.Clocks
{
    partial class Clock_ASCII
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
            this.lblDigital = new System.Windows.Forms.Label();
            this.timer_ASCII = new System.Windows.Forms.Timer(this.components);
            this.rtxtBox_ASCII = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(506, 239);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 2;
            this.lblDigital.Text = "00:00:00";
            // 
            // timer_ASCII
            // 
            this.timer_ASCII.Interval = 1000;
            this.timer_ASCII.Tick += new System.EventHandler(this.timer_ASCII_Tick);
            // 
            // rtxtBox_ASCII
            // 
            this.rtxtBox_ASCII.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtBox_ASCII.Location = new System.Drawing.Point(12, 53);
            this.rtxtBox_ASCII.Name = "rtxtBox_ASCII";
            this.rtxtBox_ASCII.Size = new System.Drawing.Size(574, 96);
            this.rtxtBox_ASCII.TabIndex = 3;
            this.rtxtBox_ASCII.Text = "";
            // 
            // Clock_ASCII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 273);
            this.Controls.Add(this.rtxtBox_ASCII);
            this.Controls.Add(this.lblDigital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_ASCII";
            this.Text = "ASCII clock";
            this.Load += new System.EventHandler(this.Clock_ASCII_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timer_ASCII;
        private System.Windows.Forms.RichTextBox rtxtBox_ASCII;
    }
}