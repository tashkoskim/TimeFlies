
namespace TimeFlies.Clocks
{
    partial class Clock_Roman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_Roman));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRoman = new System.Windows.Forms.Label();
            this.lblDigital = new System.Windows.Forms.Label();
            this.timerRoman = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TimeFlies.Properties.Resources.Roman;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 331);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRoman
            // 
            this.lblRoman.AutoSize = true;
            this.lblRoman.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoman.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRoman.Location = new System.Drawing.Point(100, 61);
            this.lblRoman.Name = "lblRoman";
            this.lblRoman.Size = new System.Drawing.Size(95, 45);
            this.lblRoman.TabIndex = 1;
            this.lblRoman.Text = "nihil";
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(430, 173);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 17;
            this.lblDigital.Text = "00:00:00";
            // 
            // timerRoman
            // 
            this.timerRoman.Enabled = true;
            this.timerRoman.Interval = 1000;
            this.timerRoman.Tick += new System.EventHandler(this.timerRoman_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Omnium Rerum Principia Parva Sunt";
            // 
            // Clock_Roman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.lblRoman);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_Roman";
            this.Text = "Roman clock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRoman;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timerRoman;
        private System.Windows.Forms.Label label1;
    }
}