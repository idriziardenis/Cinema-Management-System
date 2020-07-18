using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKinemase
{
    public partial class MoviesBookingPanel : UserControl
    {
        public MoviesBookingPanel()
        {
            InitializeComponent();
        }

        public string BookingDate { get { return lblDate.Text; } set { lblDate.Text = value; } }
        public string BookingHall { get { return lblHallName.Text; } set { lblHallName.Text = value; } }
        public string BookingTime { get { return lblTime.Text; } set { lblTime.Text = value; } }
        public string BookingChair { get { return lblChair.Text; } set { lblChair.Text = value; } }
        public string BookingClient { get { return lblClient.Text; } set { lblClient.Text = value; } }


    }
}
