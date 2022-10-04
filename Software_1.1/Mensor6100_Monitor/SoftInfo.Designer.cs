namespace Zanasi4700
{
    partial class SoftInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImgeSoftInfo = new System.Windows.Forms.PictureBox();
            this.lb_Language = new System.Windows.Forms.Label();
            this.lb_NETFramework = new System.Windows.Forms.Label();
            this.lb_Architecture = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Department = new System.Windows.Forms.Label();
            this.lb_Company = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgeSoftInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ImgeSoftInfo);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 116);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ImgeSoftInfo
            // 
            this.ImgeSoftInfo.Image = ((System.Drawing.Image)(resources.GetObject("ImgeSoftInfo.Image")));
            this.ImgeSoftInfo.Location = new System.Drawing.Point(19, -1);
            this.ImgeSoftInfo.Name = "ImgeSoftInfo";
            this.ImgeSoftInfo.Size = new System.Drawing.Size(163, 116);
            this.ImgeSoftInfo.TabIndex = 0;
            this.ImgeSoftInfo.TabStop = false;
            // 
            // lb_Language
            // 
            this.lb_Language.AutoSize = true;
            this.lb_Language.Location = new System.Drawing.Point(259, 152);
            this.lb_Language.Name = "lb_Language";
            this.lb_Language.Size = new System.Drawing.Size(52, 13);
            this.lb_Language.TabIndex = 20;
            this.lb_Language.Text = "Visual C#";
            // 
            // lb_NETFramework
            // 
            this.lb_NETFramework.AutoSize = true;
            this.lb_NETFramework.Location = new System.Drawing.Point(259, 132);
            this.lb_NETFramework.Name = "lb_NETFramework";
            this.lb_NETFramework.Size = new System.Drawing.Size(105, 13);
            this.lb_NETFramework.TabIndex = 19;
            this.lb_NETFramework.Text = ".NET Framework 4.0";
            // 
            // lb_Architecture
            // 
            this.lb_Architecture.AutoSize = true;
            this.lb_Architecture.Location = new System.Drawing.Point(259, 174);
            this.lb_Architecture.Name = "lb_Architecture";
            this.lb_Architecture.Size = new System.Drawing.Size(80, 13);
            this.lb_Architecture.TabIndex = 18;
            this.lb_Architecture.Text = "32 bits / 64 bits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "October - 2019";
            // 
            // lb_Department
            // 
            this.lb_Department.AutoSize = true;
            this.lb_Department.Location = new System.Drawing.Point(18, 152);
            this.lb_Department.Name = "lb_Department";
            this.lb_Department.Size = new System.Drawing.Size(137, 13);
            this.lb_Department.TabIndex = 16;
            this.lb_Department.Text = "Mechanization Department ";
            // 
            // lb_Company
            // 
            this.lb_Company.AutoSize = true;
            this.lb_Company.Location = new System.Drawing.Point(18, 132);
            this.lb_Company.Name = "lb_Company";
            this.lb_Company.Size = new System.Drawing.Size(134, 13);
            this.lb_Company.TabIndex = 15;
            this.lb_Company.Text = "Sensata Technologies Inc.";
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Location = new System.Drawing.Point(18, 174);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(60, 13);
            this.lb_version.TabIndex = 14;
            this.lb_version.Text = "Version 1.0";
            // 
            // SoftInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 226);
            this.Controls.Add(this.lb_Language);
            this.Controls.Add(this.lb_NETFramework);
            this.Controls.Add(this.lb_Architecture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Department);
            this.Controls.Add(this.lb_Company);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SoftInfo";
            this.Text = "Sensata Technologies Software | Software Information";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgeSoftInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ImgeSoftInfo;
        private System.Windows.Forms.Label lb_Language;
        private System.Windows.Forms.Label lb_NETFramework;
        private System.Windows.Forms.Label lb_Architecture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Department;
        private System.Windows.Forms.Label lb_Company;
        private System.Windows.Forms.Label lb_version;
    }
}