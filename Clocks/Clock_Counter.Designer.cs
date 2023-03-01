
namespace TimeFlies.Clocks
{
    partial class Clock_Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_Counter));
            this.lblDigital = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxSS2 = new System.Windows.Forms.PictureBox();
            this.pBoxSS1 = new System.Windows.Forms.PictureBox();
            this.pBoxMM2 = new System.Windows.Forms.PictureBox();
            this.pBoxMM1 = new System.Windows.Forms.PictureBox();
            this.pBoxHH2 = new System.Windows.Forms.PictureBox();
            this.pBoxHH1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.BackColor = System.Drawing.Color.Transparent;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(735, 3);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 21;
            this.lblDigital.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txtBoxInfo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(35, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 194);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tekst";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.BackColor = System.Drawing.Color.Black;
            this.txtBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxInfo.ForeColor = System.Drawing.Color.White;
            this.txtBoxInfo.Location = new System.Drawing.Point(7, 30);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ReadOnly = true;
            this.txtBoxInfo.Size = new System.Drawing.Size(746, 158);
            this.txtBoxInfo.TabIndex = 1;
            this.txtBoxInfo.TabStop = false;
            this.txtBoxInfo.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pBoxSS2);
            this.panel1.Controls.Add(this.pBoxSS1);
            this.panel1.Controls.Add(this.pBoxMM2);
            this.panel1.Controls.Add(this.pBoxMM1);
            this.panel1.Controls.Add(this.pBoxHH2);
            this.panel1.Controls.Add(this.pBoxHH1);
            this.panel1.Location = new System.Drawing.Point(35, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 265);
            this.panel1.TabIndex = 24;
            // 
            // pBoxSS2
            // 
            this.pBoxSS2.Image = global::TimeFlies.Properties.Resources.counterS2_0;
            this.pBoxSS2.Location = new System.Drawing.Point(637, 7);
            this.pBoxSS2.Name = "pBoxSS2";
            this.pBoxSS2.Size = new System.Drawing.Size(120, 250);
            this.pBoxSS2.TabIndex = 5;
            this.pBoxSS2.TabStop = false;
            // 
            // pBoxSS1
            // 
            this.pBoxSS1.Image = global::TimeFlies.Properties.Resources.counterS1_0;
            this.pBoxSS1.Location = new System.Drawing.Point(511, 7);
            this.pBoxSS1.Name = "pBoxSS1";
            this.pBoxSS1.Size = new System.Drawing.Size(120, 250);
            this.pBoxSS1.TabIndex = 4;
            this.pBoxSS1.TabStop = false;
            // 
            // pBoxMM2
            // 
            this.pBoxMM2.Image = global::TimeFlies.Properties.Resources.counter_0;
            this.pBoxMM2.Location = new System.Drawing.Point(385, 7);
            this.pBoxMM2.Name = "pBoxMM2";
            this.pBoxMM2.Size = new System.Drawing.Size(120, 250);
            this.pBoxMM2.TabIndex = 3;
            this.pBoxMM2.TabStop = false;
            // 
            // pBoxMM1
            // 
            this.pBoxMM1.Image = global::TimeFlies.Properties.Resources.counterM1_0;
            this.pBoxMM1.Location = new System.Drawing.Point(259, 7);
            this.pBoxMM1.Name = "pBoxMM1";
            this.pBoxMM1.Size = new System.Drawing.Size(120, 250);
            this.pBoxMM1.TabIndex = 2;
            this.pBoxMM1.TabStop = false;
            // 
            // pBoxHH2
            // 
            this.pBoxHH2.Image = global::TimeFlies.Properties.Resources.counter_0;
            this.pBoxHH2.Location = new System.Drawing.Point(133, 7);
            this.pBoxHH2.Name = "pBoxHH2";
            this.pBoxHH2.Size = new System.Drawing.Size(120, 250);
            this.pBoxHH2.TabIndex = 1;
            this.pBoxHH2.TabStop = false;
            // 
            // pBoxHH1
            // 
            this.pBoxHH1.Image = global::TimeFlies.Properties.Resources.counterH1_0;
            this.pBoxHH1.Location = new System.Drawing.Point(7, 7);
            this.pBoxHH1.Name = "pBoxHH1";
            this.pBoxHH1.Size = new System.Drawing.Size(120, 250);
            this.pBoxHH1.TabIndex = 0;
            this.pBoxHH1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Податоците за празници се од: https://www.mtsp.gov.mk/programa-za-nerabotni-denov" +
    "i.nspx";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblDigital);
            this.panel2.Location = new System.Drawing.Point(-1, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 37);
            this.panel2.TabIndex = 26;
            // 
            // Clock_Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimeFlies.Properties.Resources.sun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(826, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_Counter";
            this.Text = "Counter clock";
            this.Load += new System.EventHandler(this.Clock_Counter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxSS2;
        private System.Windows.Forms.PictureBox pBoxSS1;
        private System.Windows.Forms.PictureBox pBoxMM2;
        private System.Windows.Forms.PictureBox pBoxMM1;
        private System.Windows.Forms.PictureBox pBoxHH2;
        private System.Windows.Forms.PictureBox pBoxHH1;
        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}