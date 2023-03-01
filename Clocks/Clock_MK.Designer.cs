
namespace TimeFlies.Clocks
{
    partial class Clock_MK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_MK));
            this.timerMK = new System.Windows.Forms.Timer(this.components);
            this.lblDigital = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCas = new System.Windows.Forms.Label();
            this.lblMM = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMK
            // 
            this.timerMK.Enabled = true;
            this.timerMK.Interval = 1000;
            this.timerMK.Tick += new System.EventHandler(this.timerMK_Tick);
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(374, 247);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 16;
            this.lblDigital.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TimeFlies.Properties.Resources.Macedonia;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 336);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Точно е:";
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCas.ForeColor = System.Drawing.Color.Red;
            this.lblCas.Location = new System.Drawing.Point(25, 111);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(36, 28);
            this.lblCas.TabIndex = 19;
            this.lblCas.Text = "hh";
            // 
            // lblMM
            // 
            this.lblMM.AutoSize = true;
            this.lblMM.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMM.ForeColor = System.Drawing.Color.Red;
            this.lblMM.Location = new System.Drawing.Point(25, 148);
            this.lblMM.Name = "lblMM";
            this.lblMM.Size = new System.Drawing.Size(48, 28);
            this.lblMM.TabIndex = 20;
            this.lblMM.Text = "mm";
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSS.ForeColor = System.Drawing.Color.Red;
            this.lblSS.Location = new System.Drawing.Point(25, 185);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(30, 28);
            this.lblSS.TabIndex = 21;
            this.lblSS.Text = "ss";
            // 
            // Clock_MK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblMM);
            this.Controls.Add(this.lblCas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_MK";
            this.Text = "Македонски часовник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMK;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.Label lblMM;
        private System.Windows.Forms.Label lblSS;
    }
}