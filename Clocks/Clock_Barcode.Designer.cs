
namespace TimeFlies.Clocks
{
    partial class Clock_Barcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_Barcode));
            this.lblHH = new System.Windows.Forms.Label();
            this.lblDigital = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHH
            // 
            this.lblHH.AutoSize = true;
            this.lblHH.Font = new System.Drawing.Font("Libre Barcode 128", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHH.ForeColor = System.Drawing.Color.Black;
            this.lblHH.Location = new System.Drawing.Point(5, 49);
            this.lblHH.Name = "lblHH";
            this.lblHH.Size = new System.Drawing.Size(640, 267);
            this.lblHH.TabIndex = 0;
            this.lblHH.Text = "000000";
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(777, 312);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 18;
            this.lblDigital.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock_Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 346);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.lblHH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_Barcode";
            this.Text = "Barcode clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHH;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timer1;
    }
}