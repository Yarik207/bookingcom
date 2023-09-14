namespace bookingcom
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PassLB = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.EnterBut = new System.Windows.Forms.Button();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataExitLB = new System.Windows.Forms.Label();
            this.dataEnterLB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CloseFilButton = new System.Windows.Forms.Button();
            this.HotelCB = new System.Windows.Forms.ComboBox();
            this.HotelLB = new System.Windows.Forms.Label();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.CityLable = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HotelName2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HotelNameLB = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LoginPanel.Controls.Add(this.PassLB);
            this.LoginPanel.Controls.Add(this.PassTB);
            this.LoginPanel.Controls.Add(this.LoginTB);
            this.LoginPanel.Controls.Add(this.LogLabel);
            this.LoginPanel.Controls.Add(this.EnterBut);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1141, 54);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // PassLB
            // 
            this.PassLB.AutoSize = true;
            this.PassLB.Location = new System.Drawing.Point(269, 15);
            this.PassLB.Name = "PassLB";
            this.PassLB.Size = new System.Drawing.Size(80, 25);
            this.PassLB.TabIndex = 4;
            this.PassLB.Text = "Пароль";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(355, 10);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(149, 30);
            this.PassTB.TabIndex = 3;
            this.PassTB.TextChanged += new System.EventHandler(this.PassTB_TextChanged);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(88, 10);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(149, 30);
            this.LoginTB.TabIndex = 2;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(12, 18);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(68, 25);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Логин";
            // 
            // EnterBut
            // 
            this.EnterBut.Location = new System.Drawing.Point(510, 10);
            this.EnterBut.Name = "EnterBut";
            this.EnterBut.Size = new System.Drawing.Size(132, 29);
            this.EnterBut.TabIndex = 0;
            this.EnterBut.Text = "Войти";
            this.EnterBut.UseVisualStyleBackColor = true;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.dateTimePicker2);
            this.FiltrPanel.Controls.Add(this.dataExitLB);
            this.FiltrPanel.Controls.Add(this.dataEnterLB);
            this.FiltrPanel.Controls.Add(this.dateTimePicker1);
            this.FiltrPanel.Controls.Add(this.CloseFilButton);
            this.FiltrPanel.Controls.Add(this.HotelCB);
            this.FiltrPanel.Controls.Add(this.HotelLB);
            this.FiltrPanel.Controls.Add(this.CityCB);
            this.FiltrPanel.Controls.Add(this.CityLable);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 54);
            this.FiltrPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1141, 130);
            this.FiltrPanel.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(752, 43);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(113, 80);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(505, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dataExitLB
            // 
            this.dataExitLB.AutoSize = true;
            this.dataExitLB.Location = new System.Drawing.Point(368, 93);
            this.dataExitLB.Name = "dataExitLB";
            this.dataExitLB.Size = new System.Drawing.Size(136, 25);
            this.dataExitLB.TabIndex = 7;
            this.dataExitLB.Text = "Дата Выезда";
            this.dataExitLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataEnterLB
            // 
            this.dataEnterLB.AutoSize = true;
            this.dataEnterLB.Location = new System.Drawing.Point(371, 51);
            this.dataEnterLB.Name = "dataEnterLB";
            this.dataEnterLB.Size = new System.Drawing.Size(133, 25);
            this.dataEnterLB.TabIndex = 6;
            this.dataEnterLB.Text = "Дата Заезда";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CloseFilButton
            // 
            this.CloseFilButton.Location = new System.Drawing.Point(0, 0);
            this.CloseFilButton.Name = "CloseFilButton";
            this.CloseFilButton.Size = new System.Drawing.Size(102, 41);
            this.CloseFilButton.TabIndex = 4;
            this.CloseFilButton.Text = "Закрыть";
            this.CloseFilButton.UseVisualStyleBackColor = true;
            this.CloseFilButton.Click += new System.EventHandler(this.CloseFilButton_Click);
            // 
            // HotelCB
            // 
            this.HotelCB.FormattingEnabled = true;
            this.HotelCB.Items.AddRange(new object[] {
            "Волга",
            "Советская"});
            this.HotelCB.Location = new System.Drawing.Point(121, 90);
            this.HotelCB.Name = "HotelCB";
            this.HotelCB.Size = new System.Drawing.Size(200, 33);
            this.HotelCB.TabIndex = 3;
            // 
            // HotelLB
            // 
            this.HotelLB.AutoSize = true;
            this.HotelLB.Location = new System.Drawing.Point(3, 93);
            this.HotelLB.Name = "HotelLB";
            this.HotelLB.Size = new System.Drawing.Size(112, 25);
            this.HotelLB.TabIndex = 2;
            this.HotelLB.Text = "Гостиница";
            this.HotelLB.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CityCB
            // 
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Items.AddRange(new object[] {
            "Мухосранск ",
            "и т д"});
            this.CityCB.Location = new System.Drawing.Point(121, 48);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(200, 33);
            this.CityCB.TabIndex = 1;
            // 
            // CityLable
            // 
            this.CityLable.AutoSize = true;
            this.CityLable.Location = new System.Drawing.Point(3, 51);
            this.CityLable.Name = "CityLable";
            this.CityLable.Size = new System.Drawing.Size(79, 25);
            this.CityLable.TabIndex = 0;
            this.CityLable.Text = "Города";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.HotelName2);
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Controls.Add(this.HotelNameLB);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 184);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1141, 321);
            this.InfoPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(291, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Гостиница ,,Венец,,";
            this.pictureBox2.Click += new System.EventHandler(this.HotelClick);
            // 
            // HotelName2
            // 
            this.HotelName2.AutoSize = true;
            this.HotelName2.Location = new System.Drawing.Point(285, 18);
            this.HotelName2.Name = "HotelName2";
            this.HotelName2.Size = new System.Drawing.Size(194, 25);
            this.HotelName2.TabIndex = 2;
            this.HotelName2.Text = "Гостиница ,,Венец,,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Гостиница ,,Советская,,";
            this.pictureBox1.Click += new System.EventHandler(this.HotelClick);
            // 
            // HotelNameLB
            // 
            this.HotelNameLB.AutoSize = true;
            this.HotelNameLB.Location = new System.Drawing.Point(13, 18);
            this.HotelNameLB.Name = "HotelNameLB";
            this.HotelNameLB.Size = new System.Drawing.Size(235, 25);
            this.HotelNameLB.TabIndex = 0;
            this.HotelNameLB.Text = "Гостиница ,,Советская,,";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 505);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label PassLB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Button EnterBut;
        private System.Windows.Forms.Label CityLable;
        private System.Windows.Forms.ComboBox CityCB;
        private System.Windows.Forms.Label HotelLB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dataExitLB;
        private System.Windows.Forms.Label dataEnterLB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button CloseFilButton;
        private System.Windows.Forms.ComboBox HotelCB;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HotelNameLB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label HotelName2;
    }
}

