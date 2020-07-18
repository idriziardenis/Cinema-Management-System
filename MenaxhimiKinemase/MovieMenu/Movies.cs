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
    public partial class Movies : Form
    {
        List<Movie> all;
        public Movies()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            new AddNewMovieForm().ShowDialog();
        }

        private void ShowMovies(string title)
        {
            if (fpnMovies.Controls.Count > 0)
            {
                fpnMovies.Controls.Clear();
            }
            if (all == null)
            {
                all = new MovieBLL().RetrieveALL();
            }
            List<Movie> filtered = new List<Movie>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Title.ToLower(), title.ToLower()))
                {
                    filtered.Add(item);
                }
            }
            MoviePanel[] movies = new MoviePanel[filtered.Count];
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = new MoviePanel(table.Size.Width, table.Size.Height);
                movies[i].ID = filtered[i].ID.ToString();
                movies[i].Title = filtered[i].Title;
                movies[i].Description = filtered[i].Description;
                try
                {
                    movies[i].MovieLogo = Image.FromFile(@"" + filtered[i].ImagePath);
                }
                catch (Exception)
                {

                }
                movies[i].ReleaseDate = filtered[i].ReleaseDate.ToString("dd-MM-yyyy");
                movies[i].Category = filtered[i].Category.Name;
                if (filtered[i].isActive == true)
                    movies[i].Status.Text = "Active";
                else
                    movies[i].Status.Text = "Inactive";
                movies[i].Price = filtered[i].Price + " $";
                movies[i].Duration = filtered[i].Duration.ToString();
                movies[i].TrailerLink = filtered[i].TrailerLink;
                movies[i].MinimumAge = filtered[i].MinimumAge.ToString();
                fpnMovies.Controls.Add(movies[i]);
            }
        }
        private void ShowMovies(bool active)
        {
            all = new MovieBLL().RetrieveALL();
            List<Movie> filtered = new List<Movie>();
            if (active == true)
            {
                foreach (var item in all)
                {
                    if (item.isActive == true)
                    {
                        filtered.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in all)
                {
                    if (item.isActive == false)
                    {
                        filtered.Add(item);
                    }
                }
            }
            if (fpnMovies.Controls.Count > 0)
            {
                fpnMovies.Controls.Clear();
            }
            MoviePanel[] movies = new MoviePanel[filtered.Count];
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = new MoviePanel(table.Size.Width, table.Size.Height);
                movies[i].ID = filtered[i].ID.ToString();
                movies[i].Title = filtered[i].Title;
                movies[i].Description = filtered[i].Description;
                try
                {
                    movies[i].MovieLogo = Image.FromFile(@"" + filtered[i].ImagePath);
                }
                catch (Exception)
                {

                }
                movies[i].ReleaseDate = filtered[i].ReleaseDate.ToString("dd-MM-yyyy");
                movies[i].Category = filtered[i].Category.Name;
                if (filtered[i].isActive == true)
                    movies[i].Status.Text = "Active";
                else
                    movies[i].Status.Text = "Inactive";
                movies[i].Price = filtered[i].Price + " $";
                movies[i].Duration = filtered[i].Duration.ToString();
                movies[i].TrailerLink = filtered[i].TrailerLink;
                movies[i].MinimumAge = filtered[i].MinimumAge.ToString();
                fpnMovies.Controls.Add(movies[i]);
            }
        }
        private void ShowMovies()
        {
            if (fpnMovies.Controls.Count > 0)
            {
                fpnMovies.Controls.Clear();
            }
            var all = new MovieBLL().RetrieveALL();
            
            MoviePanel[] movies = new MoviePanel[all.Count];
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = new MoviePanel(table.Size.Width, table.Size.Height);
                movies[i].ID = all[i].ID.ToString();
                movies[i].Title = all[i].Title;
                movies[i].Description = all[i].Description;
                try
                {
                    movies[i].MovieLogo = Image.FromFile(@"" + all[i].ImagePath);
                }
                catch (Exception)
                {

                }
                movies[i].ReleaseDate = all[i].ReleaseDate.ToString("dd-MM-yyyy");
                movies[i].Category = all[i].Category.Name;
                if (all[i].isActive == true)
                    movies[i].Status.Text = "Active";
                else
                    movies[i].Status.Text = "Inactive";
                movies[i].Price = all[i].Price + " $";
                movies[i].Duration = all[i].Duration.ToString();
                movies[i].TrailerLink = all[i].TrailerLink;
                movies[i].MinimumAge = all[i].MinimumAge.ToString();
                fpnMovies.Controls.Add(movies[i]);
            }
        }

        private void Edit_Click(object sender, EventArgs e, int movieID)
        {
            new EditMovie(movieID).Show();
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ShowMovies();
            }
            else
                ShowMovies(txtSearch.Text);
        }

        private void cbAction_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected movies!", $"Are you sure that you want to delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (MoviePanel item in fpnMovies.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new MovieBLL().Delete(int.Parse(item.ID));
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " movies has been deleted!");
                        cbAction.Text = "Choose Action";
                    }
                    else
                    {
                        MessageBox.Show("You need to select one or more!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Deleting canceled!");
                }
            }
            else if (cbAction.Text == "Export to Excel")
            {
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected movies!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Movie> movies = new List<Movie>();
                    int no = 0;
                    foreach (MoviePanel item in fpnMovies.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            movies.Add(new MovieBLL().Retrieve(int.Parse(item.ID)));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<Movie>(movies));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " movies has been exported to excel!");
                        cbAction.Text = "Choose Action";
                    }
                    else
                    {
                        MessageBox.Show("You need to select one or more!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Exporting canceled!");
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowMovies();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            ShowMovies(true);
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            ShowMovies(false);
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            ShowMovies();
        }

        private void chCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (MoviePanel item in fpnMovies.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (MoviePanel item in fpnMovies.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowMovies();
        }
    }
}

