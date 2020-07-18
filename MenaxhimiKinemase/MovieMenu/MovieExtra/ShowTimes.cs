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
    public partial class ShowTimes : Form
    {
        Movie m;
        public ShowTimes(Movie movie)
        {
            m = movie;
            InitializeComponent();
        }

        private void ShowTimes_Load(object sender, EventArgs e)
        {
            //lblHeader.Text = "Show Times of MOVIE: " + m.Tittle;
            pbMoviePhoto.Image = Image.FromFile(@"" + m.ImagePath);
            ShowShowTimes();
        }
        private void ShowShowTimes()
        {
            //if (fpnShowTimes.Controls.Count > 0)
            //{
            //    fpnShowTimes.Controls.Clear();
            //}
            //var st = ScheduleStore.ShowTimes(m);
            //ShowTimePanel[] stp = new ShowTimePanel[st.Count];
            //for (int i = 0; i < stp.Length; i++)
            //{
            //    stp[i] = new ShowTimePanel();

            //    stp[i].ShowTimeDate = st[i].StartTime.ToString("dd/MM/yyyy");
            //    stp[i].ShowTimeTime = st[i].StartTime.ToString("HH:mm");
            //    stp[i].ShowTimeHall = st[i].Hall.Name;
            //    fpnShowTimes.Controls.Add(stp[i]);
            //}
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
