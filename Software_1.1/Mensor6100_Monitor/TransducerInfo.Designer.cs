namespace Zanasi4700
{
    partial class TransducerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransducerInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Settings = new System.Windows.Forms.Label();
            this.lb_protocol = new System.Windows.Forms.Label();
            this.lb_PowerSupply = new System.Windows.Forms.Label();
            this.lb_HdFd = new System.Windows.Forms.Label();
            this.lb_Model = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 116);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(327, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Settings
            // 
            this.lb_Settings.AutoSize = true;
            this.lb_Settings.Location = new System.Drawing.Point(325, 182);
            this.lb_Settings.Name = "lb_Settings";
            this.lb_Settings.Size = new System.Drawing.Size(93, 13);
            this.lb_Settings.TabIndex = 23;
            this.lb_Settings.Text = "57600, None, 8, 1";
            // 
            // lb_protocol
            // 
            this.lb_protocol.AutoSize = true;
            this.lb_protocol.Location = new System.Drawing.Point(325, 138);
            this.lb_protocol.Name = "lb_protocol";
            this.lb_protocol.Size = new System.Drawing.Size(40, 13);
            this.lb_protocol.TabIndex = 22;
            this.lb_protocol.Text = "RS485";
            // 
            // lb_PowerSupply
            // 
            this.lb_PowerSupply.AutoSize = true;
            this.lb_PowerSupply.Location = new System.Drawing.Point(325, 204);
            this.lb_PowerSupply.Name = "lb_PowerSupply";
            this.lb_PowerSupply.Size = new System.Drawing.Size(44, 13);
            this.lb_PowerSupply.TabIndex = 21;
            this.lb_PowerSupply.Text = "+12Vcd";
            // 
            // lb_HdFd
            // 
            this.lb_HdFd.AutoSize = true;
            this.lb_HdFd.Location = new System.Drawing.Point(325, 160);
            this.lb_HdFd.Name = "lb_HdFd";
            this.lb_HdFd.Size = new System.Drawing.Size(125, 13);
            this.lb_HdFd.TabIndex = 24;
            this.lb_HdFd.Text = "Half Duplex / Full Duplex";
            // 
            // lb_Model
            // 
            this.lb_Model.AutoSize = true;
            this.lb_Model.Location = new System.Drawing.Point(33, 138);
            this.lb_Model.Name = "lb_Model";
            this.lb_Model.Size = new System.Drawing.Size(87, 13);
            this.lb_Model.TabIndex = 25;
            this.lb_Model.Text = "Model CPT 6100";
            // 
            // TransducerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 226);
            this.Controls.Add(this.lb_Model);
            this.Controls.Add(this.lb_HdFd);
            this.Controls.Add(this.lb_Settings);
            this.Controls.Add(this.lb_protocol);
            this.Controls.Add(this.lb_PowerSupply);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransducerInfo";
            this.Text = "Sensata Technologies Software | Mensor CPT 6100";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_Settings;
        private System.Windows.Forms.Label lb_protocol;
        private System.Windows.Forms.Label lb_PowerSupply;
        private System.Windows.Forms.Label lb_HdFd;
        private System.Windows.Forms.Label lb_Model;
    }
}