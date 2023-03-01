
namespace TimeFlies.Clocks
{
    partial class Clock_predator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_predator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxMM2 = new System.Windows.Forms.PictureBox();
            this.pBoxMM1 = new System.Windows.Forms.PictureBox();
            this.pBoxHH2 = new System.Windows.Forms.PictureBox();
            this.pBoxHH1 = new System.Windows.Forms.PictureBox();
            this.pBoxSS1 = new System.Windows.Forms.PictureBox();
            this.pBoxSS2 = new System.Windows.Forms.PictureBox();
            this.lblDigital = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TimeFlies.Properties.Resources.predator_device;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pBoxMM2);
            this.panel1.Controls.Add(this.pBoxMM1);
            this.panel1.Controls.Add(this.pBoxHH2);
            this.panel1.Controls.Add(this.pBoxHH1);
            this.panel1.Location = new System.Drawing.Point(38, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 194);
            this.panel1.TabIndex = 0;
            // 
            // pBoxMM2
            // 
            this.pBoxMM2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMM2.Location = new System.Drawing.Point(532, 47);
            this.pBoxMM2.Name = "pBoxMM2";
            this.pBoxMM2.Size = new System.Drawing.Size(99, 98);
            this.pBoxMM2.TabIndex = 6;
            this.pBoxMM2.TabStop = false;
            // 
            // pBoxMM1
            // 
            this.pBoxMM1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMM1.Location = new System.Drawing.Point(397, 47);
            this.pBoxMM1.Name = "pBoxMM1";
            this.pBoxMM1.Size = new System.Drawing.Size(99, 98);
            this.pBoxMM1.TabIndex = 5;
            this.pBoxMM1.TabStop = false;
            // 
            // pBoxHH2
            // 
            this.pBoxHH2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxHH2.Location = new System.Drawing.Point(262, 47);
            this.pBoxHH2.Name = "pBoxHH2";
            this.pBoxHH2.Size = new System.Drawing.Size(99, 98);
            this.pBoxHH2.TabIndex = 4;
            this.pBoxHH2.TabStop = false;
            // 
            // pBoxHH1
            // 
            this.pBoxHH1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxHH1.Location = new System.Drawing.Point(134, 47);
            this.pBoxHH1.Name = "pBoxHH1";
            this.pBoxHH1.Size = new System.Drawing.Size(99, 98);
            this.pBoxHH1.TabIndex = 3;
            this.pBoxHH1.TabStop = false;
            // 
            // pBoxSS1
            // 
            this.pBoxSS1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSS1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxSS1.Location = new System.Drawing.Point(38, 236);
            this.pBoxSS1.Name = "pBoxSS1";
            this.pBoxSS1.Size = new System.Drawing.Size(99, 98);
            this.pBoxSS1.TabIndex = 1;
            this.pBoxSS1.TabStop = false;
            // 
            // pBoxSS2
            // 
            this.pBoxSS2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSS2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxSS2.Location = new System.Drawing.Point(143, 236);
            this.pBoxSS2.Name = "pBoxSS2";
            this.pBoxSS2.Size = new System.Drawing.Size(99, 98);
            this.pBoxSS2.TabIndex = 2;
            this.pBoxSS2.TabStop = false;
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.BackColor = System.Drawing.Color.Transparent;
            this.lblDigital.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigital.ForeColor = System.Drawing.Color.Gray;
            this.lblDigital.Location = new System.Drawing.Point(659, 307);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(80, 25);
            this.lblDigital.TabIndex = 20;
            this.lblDigital.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock_predator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimeFlies.Properties.Resources._4k_aluminum_textures_horizontal_metal_texture_gray_metal_plate_metal_textures_besthqwallpapers_com_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 341);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.pBoxSS2);
            this.Controls.Add(this.pBoxSS1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock_predator";
            this.Text = "Predator clock";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxSS1;
        private System.Windows.Forms.PictureBox pBoxSS2;
        private System.Windows.Forms.PictureBox pBoxMM2;
        private System.Windows.Forms.PictureBox pBoxMM1;
        private System.Windows.Forms.PictureBox pBoxHH2;
        private System.Windows.Forms.PictureBox pBoxHH1;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timer1;
    }
}