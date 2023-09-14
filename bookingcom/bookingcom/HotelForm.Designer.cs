namespace bookingcom
{
    partial class HotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.HotelPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.HotelImagePB = new System.Windows.Forms.PictureBox();
            this.HotelLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HotelName2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.HotelNameLB = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HotelPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelPanel
            // 
            this.HotelPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HotelPanel.Controls.Add(this.pictureBox1);
            this.HotelPanel.Controls.Add(this.textBox1);
            this.HotelPanel.Controls.Add(this.HotelLabel);
            this.HotelPanel.Controls.Add(this.HotelImagePB);
            this.HotelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HotelPanel.Location = new System.Drawing.Point(0, 0);
            this.HotelPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HotelPanel.Name = "HotelPanel";
            this.HotelPanel.Size = new System.Drawing.Size(1000, 225);
            this.HotelPanel.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InfoPanel.Controls.Add(this.pictureBox4);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.pictureBox3);
            this.InfoPanel.Controls.Add(this.HotelName2);
            this.InfoPanel.Controls.Add(this.HotelNameLB);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 225);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1000, 309);
            this.InfoPanel.TabIndex = 1;
            // 
            // HotelImagePB
            // 
            this.HotelImagePB.Location = new System.Drawing.Point(15, 4);
            this.HotelImagePB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HotelImagePB.Name = "HotelImagePB";
            this.HotelImagePB.Size = new System.Drawing.Size(315, 214);
            this.HotelImagePB.TabIndex = 0;
            this.HotelImagePB.TabStop = false;
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelLabel.Location = new System.Drawing.Point(336, 5);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(92, 32);
            this.HotelLabel.TabIndex = 1;
            this.HotelLabel.Text = "label1";
            this.HotelLabel.Click += new System.EventHandler(this.HotelLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(342, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(511, 124);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Величайшие \r\nгостиницы \r\nмира ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(276, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // HotelName2
            // 
            this.HotelName2.AutoSize = true;
            this.HotelName2.Location = new System.Drawing.Point(270, 103);
            this.HotelName2.Name = "HotelName2";
            this.HotelName2.Size = new System.Drawing.Size(177, 20);
            this.HotelName2.TabIndex = 6;
            this.HotelName2.Text = "номер двухместный";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(231, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // HotelNameLB
            // 
            this.HotelNameLB.AutoSize = true;
            this.HotelNameLB.Location = new System.Drawing.Point(-2, 103);
            this.HotelNameLB.Name = "HotelNameLB";
            this.HotelNameLB.Size = new System.Drawing.Size(184, 20);
            this.HotelNameLB.TabIndex = 4;
            this.HotelNameLB.Text = "Номер одноместный\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(555, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(231, 166);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "номер люкс";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.HotelPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            this.HotelPanel.ResumeLayout(false);
            this.HotelPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HotelPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.PictureBox HotelImagePB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label HotelName2;
        private System.Windows.Forms.Label HotelNameLB;
    }
}