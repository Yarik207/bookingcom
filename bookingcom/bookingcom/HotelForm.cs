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
        public HotelForm(string name)
        {
            InitializeComponent();
            HotelLabel.Text = name; 
            Text = name;
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void HotelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
