namespace bookingcom
{
    partial class RoomForm
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
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.RoomPB = new System.Windows.Forms.PictureBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BronirovanieButt = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPB)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.RoomTB);
            this.InfoPanel.Controls.Add(this.RoomLabel);
            this.InfoPanel.Controls.Add(this.RoomPB);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(900, 228);
            this.InfoPanel.TabIndex = 0;
            // 
            // RoomPanel
            // 
            this.RoomPanel.Controls.Add(this.BronirovanieButt);
            this.RoomPanel.Controls.Add(this.dateTimePicker2);
            this.RoomPanel.Controls.Add(this.label2);
            this.RoomPanel.Controls.Add(this.dateTimePicker1);
            this.RoomPanel.Controls.Add(this.label1);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPanel.Location = new System.Drawing.Point(0, 228);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(900, 278);
            this.RoomPanel.TabIndex = 1;
            // 
            // RoomPB
            // 
            this.RoomPB.Location = new System.Drawing.Point(4, 13);
            this.RoomPB.Name = "RoomPB";
            this.RoomPB.Size = new System.Drawing.Size(324, 211);
            this.RoomPB.TabIndex = 0;
            this.RoomPB.TabStop = false;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomLabel.Location = new System.Drawing.Point(335, 13);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(79, 29);
            this.RoomLabel.TabIndex = 1;
            this.RoomLabel.Text = "label1";
            this.RoomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoomTB
            // 
            this.RoomTB.Location = new System.Drawing.Point(340, 45);
            this.RoomTB.Multiline = true;
            this.RoomTB.Name = "RoomTB";
            this.RoomTB.Size = new System.Drawing.Size(450, 137);
            this.RoomTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заезда ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // BronirovanieButt
            // 
            this.BronirovanieButt.Location = new System.Drawing.Point(421, 12);
            this.BronirovanieButt.Name = "BronirovanieButt";
            this.BronirovanieButt.Size = new System.Drawing.Size(173, 90);
            this.BronirovanieButt.TabIndex = 4;
            this.BronirovanieButt.Text = "Забронировать";
            this.BronirovanieButt.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.InfoPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox RoomTB;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.PictureBox RoomPB;
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BronirovanieButt;
    }
}