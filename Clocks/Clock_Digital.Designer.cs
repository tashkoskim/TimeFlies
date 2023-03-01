
namespace TimeFlies.Clocks
{
    partial class Clock_Digital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_Digital));
            this.txtBox_Digital = new System.Windows.Forms.TextBox();
            this.lblDigital = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Digital
            // 
            this.txtBox_Digital.BackColor = System.Drawing.Color.Black;
            this.txtBox_Digital.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Digital.ForeColor = System.Drawing.Color.Red;
            this.txtBox_Digital.Location = new System.Drawing.Point(17, 12);
            this.txtBox_Digital.Multiline = true;
            this.txtBox_Digital.Name = "txtBox_Digital";
            this.txtBox_Digital.ReadOnly = true;
            this.txtBox_Digital.Size = new System.Drawing.Size(682, 182);
            this.txtBox_Digital.TabIndex = 1000;
            this.txtBox_Digital.TabStop = false;
            this.txtBox_Digital.WordWrap = false;
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(624, 201);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 1;
            this.lblDigital.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(17, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 1001;
            this.label1.Text = "Monospaced TrueType font: Courier New";
            // 
            // Clock_Digital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.txtBox_Digital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_Digital";
            this.Text = "Digital led clock";
            this.Load += new System.EventHandler(this.Clock_Digital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Digital;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}