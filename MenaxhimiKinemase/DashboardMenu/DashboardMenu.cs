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
    public partial class DashboardMenu : Form
    {
        public DashboardMenu()
        {
            InitializeComponent();
        }

        private void DashboardMenu_Load(object sender, EventArgs e)
        {
            lblClientsCount.Text = new ClientBLL().Count().ToString();
            lblEventsCount.Text = new EventBLL().Count().ToString();
            lblHallsCount.Text = new HallBLL().Count().ToString();
            lblMoviesCounts.Text = new MovieBLL().Count().ToString();
            lblSchedulesCount.Text = new ScheduleBLL().Count().ToString();
            lblTicketsCount.Text = new TicketBLL().Count().ToString();
            ShowActiveEvents();
            ShowTodayMovies();
            ShowTodayTicketsSold();
        }

        private void ShowActiveEvents()
        {
            if (fpnEvents.Controls.Count > 0)
            {
                fpnEvents.Controls.Clear();
            }
            var events = new EventBLL().RetrieveALL();
            ActiveEventsPanel[] ep = new ActiveEventsPanel[events.Count];
            for (int i = 0; i < ep.Length; i++)
            {
                ep[i] = new ActiveEventsPanel();
                ep[i].EventTittle = events[i].Title;
                ep[i].EventType = events[i].EventType.Type;
                ep[i].EventDuration = events[i].StartDate.ToString("dd/MM/yyyy") + "-" + events[i].EndDate.ToString("dd/MM/yyyy");
                ep[i].EventSale = events[i].Sales.ToString() + "%";
                fpnEvents.Controls.Add(ep[i]);
            }
        }

        private void ShowTodayMovies()
        {
            if (fpnMovies.Controls.Count > 0)
            {
                fpnMovies.Controls.Clear();
            }
            var movies = new MovieBLL().RetrieveALL();
            TodayMovies[] tm = new TodayMovies[movies.Count];
            for (int i = 0; i < tm.Length; i++)
            {
                tm[i] = new TodayMovies();
                tm[i].MovieTittle = movies[i].Title;
                tm[i].MovieReleaseDate = movies[i].ReleaseDate.ToString("dd/MM/yyyy");
                tm[i].MovieDuration = movies[i].Duration.ToString();
                tm[i].MoviePrice = movies[i].Price.ToString() + "$";
                fpnMovies.Controls.Add(tm[i]);
            }
        }

        private void ShowTodayTicketsSold()
        {
            if (fpnTickets.Controls.Count > 0)
            {
                fpnTickets.Controls.Clear();
            }
            var tickets = new TicketBLL().RetrieveALL();
            TodayTicketsPanel[] ttp = new TodayTicketsPanel[tickets.Count];
            for (int i = 0; i < ttp.Length; i++)
            {
                ttp[i] = new TodayTicketsPanel();
                ttp[i].TicketClient = tickets[i].Booking.Client.FirstName + " " + tickets[i].Booking.Client.LastName;
                ttp[i].TicketHall = tickets[i].Booking.Schedule.Hall.ID.ToString();
                ttp[i].TicketMovie = tickets[i].Booking.Schedule.Movie.Title;
                ttp[i].TicketPrice = tickets[i].Price + "$";
                fpnTickets.Controls.Add(ttp[i]);
            }
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            Stats s = new Stats();
            s.Show();
        }
    }
}
