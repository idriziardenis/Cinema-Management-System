using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BLL;
using CinemaManagement.BO;

namespace MenaxhimiKinemase
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            lblNumberOfWatchedMovies.Text = new TicketBLL().NumberOfMostWatchedMovie().ToString();
            lblMostWatchedMovie.Text = new TicketBLL().MostWatchedMovie().Title;
            //lblNumberOfMostRatedMovie.Text = ReviewStore.GetAverageRating(TicketStore.MostWatchedMovie()).ToString();
            //lblMostRatedMovie.Text = ReviewStore.GetMostRatedMovie().Tittle;
            lblGender.Text = new ClientBLL().GetGenderDomination().Name;
            lblGenderNumber.Text = new ClientBLL().GenreCount(new ClientBLL().GetGenderDomination()).ToString();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
