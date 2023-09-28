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
    public partial class RoomForm : Form
    {
        public RoomForm(string hotelname, string RoomName)
        {
            InitializeComponent();
            Text ="Гостиница " + hotelname + ": " + RoomName;
            RoomLabel.Text = "Гостиница " + hotelname + ": " + RoomName;


            RoomPB.Load("../../pictures/" + RoomName + ".jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
