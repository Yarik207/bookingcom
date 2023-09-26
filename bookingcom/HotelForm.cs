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
    public partial class HotelForm : Form
    {
        

        public HotelForm(string hotelname, int RatingHotel)
        {
            InitializeComponent();
            HotelLabel.Text = "Гостиница \"" + hotelname + "\"";
            Text = hotelname;
            Text = "Гостиница \"" + hotelname + "\"";
            HotelImagePB.Load("../../pictures/" + hotelname + ".jpg");

            int x = 342;
            for (int i = 0; i < RatingHotel; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../pictures/Star.png");
                box.Location = new Point(x, 70);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                HotelPanel.Controls.Add(box);

                x += 55;
            }

            
        }


        private void RoomClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(pb.Tag.ToString());
            rf.ShowDialog();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void HotelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
