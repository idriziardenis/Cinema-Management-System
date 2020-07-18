using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BO;

namespace MenaxhimiKinemase
{
    public partial class MovieBookings : Form
    {
        Movie m;
        public MovieBookings(Movie movie)
        {
            m = movie;
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MovieBookings_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Bookings of MOVIE: " + m.Title;
            pbMoviePhoto.Image = Image.FromFile(@"" + m.ImagePath);
            ShowBookings();
        }
        private void ShowBookings()
        {
            if (fpnShowTimes.Controls.Count > 0)
            {
                fpnShowTimes.Controls.Clear();
            }
            // b = BookingStore.GetBokingsOfMovie(m);
            //MoviesBookingPanel[] mbp = new MoviesBookingPanel[b.Count];
            //for (int i = 0; i < mbp.Length; i++)
            //{
            //    mbp[i] = new MoviesBookingPanel();

            //    mbp[i].BookingChair = b[i].Chair.ToString();
            //    mbp[i].BookingClient = b[i].Client.ToString();
            //    mbp[i].BookingDate = b[i].Schedule.StartTime.ToString("dd/MM/yyyy");
            //    mbp[i].BookingTime = b[i].Schedule.StartTime.ToString("HH:mm");
            //    mbp[i].BookingHall = b[i].Schedule.Hall.Name;
            //    fpnShowTimes.Controls.Add(mbp[i]);
            //}
        }
    }
}
