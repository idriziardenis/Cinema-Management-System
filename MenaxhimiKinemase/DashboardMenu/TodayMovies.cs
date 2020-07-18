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
    public partial class TodayMovies : UserControl
    {
        public TodayMovies()
        {
            InitializeComponent();
        }

        public string MovieTittle { get { return lblMovieTitle.Text; } set { lblMovieTitle.Text = value; } }
        public string MovieDuration { get { return lblMovieDuration.Text; } set { lblMovieDuration.Text = value; } }
        public string MoviePrice { get { return lblMoviePrice.Text; } set { lblMoviePrice.Text = value; } }
        public string MovieReleaseDate { get { return lblMovieReleaseDate.Text; } set { lblMovieReleaseDate.Text = value; } }
    }
}
