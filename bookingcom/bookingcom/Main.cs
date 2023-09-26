using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookingcom
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseFilButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height < 130)
            {
                FiltrPanel.Height = 130;
            }
            else
            {
                FiltrPanel.Height = CloseFilButton.Size.Height;
            }
        }

        private void PassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void HotelClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            HotelForm hotelform = new HotelForm(pb.Tag.ToString(), 5);
            hotelform.ShowDialog();
        }

       
        private void HotelName_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            string[] text = lb.Text.Split(new char[] { '"' });
            HotelForm hotelform = new HotelForm(text[1], 5);
            hotelform.ShowDialog();
        }
    }
}
