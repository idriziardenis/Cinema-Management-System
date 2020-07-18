using CinemaManagement.BO;
using CinemaManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKinemase
{
    public partial class BookingMenu : Form
    {
        List<Booking> bookings;
        public BookingMenu()
        {
            InitializeComponent();
        }
        private void ShowBookings()
        {
            if (fpnBookings.Controls.Count > 0)
            {
                fpnBookings.Controls.Clear();
            }
            bookings = new BookingBLL().RetrieveALL();
            BookingPanel[] booking = new BookingPanel[bookings.Count];
            for (int i = 0; i < booking.Length; i++)
            {
                booking[i] = new BookingPanel(table.Size.Width, table.Size.Height);
                booking[i].ID = bookings[i].ID.ToString();
                booking[i].MovieName = bookings[i].Schedule.Movie.Title;
                booking[i].HallName = bookings[i].Schedule.Hall.Name; ;
                booking[i].StartTime = bookings[i].Schedule.StartTime.ToString("dd-MM-yyyy HH:mm");
                booking[i].EndTime = bookings[i].Schedule.EndTime.ToString("dd-MM-yyyy HH:mm");
                booking[i].ClientName = bookings[i].Client.UserName;
                booking[i].Chair = bookings[i].Chair.Row + " , " + bookings[i].Chair.Column;
                fpnBookings.Controls.Add(booking[i]);
            }
        }

        private void ShowBookings(string moviename)
        {
            if (fpnBookings.Controls.Count > 0)
            {
                fpnBookings.Controls.Clear();
            }
            if (this.bookings == null)
            {
                this.bookings = new BookingBLL().RetrieveALL();
            }
            var all = this.bookings;
            List<Booking> bookings = new List<Booking>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Schedule.Movie.Title, moviename))
                {
                    bookings.Add(item);
                }
            }

            bookings = new BookingBLL().RetrieveALL();
            BookingPanel[] booking = new BookingPanel[bookings.Count];
            for (int i = 0; i < booking.Length; i++)
            {
                booking[i] = new BookingPanel(table.Size.Width, table.Size.Height);
                booking[i].ID = bookings[i].ID.ToString();
                booking[i].MovieName = bookings[i].Schedule.Movie.Title;
                booking[i].HallName = bookings[i].Schedule.Hall.Name; ;
                booking[i].StartTime = bookings[i].Schedule.StartTime.ToString("dd-MM-yyyy HH:mm");
                booking[i].EndTime = bookings[i].Schedule.EndTime.ToString("dd-MM-yyyy HH:mm");
                booking[i].ClientName = bookings[i].Client.UserName;
                booking[i].Chair = bookings[i].Chair.Row + " , " + bookings[i].Chair.Column;
                fpnBookings.Controls.Add(booking[i]);
            }
        }

        private void chCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (BookingPanel item in fpnBookings.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (BookingPanel item in fpnBookings.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected bookings!", $"Are you sure that you want to bookings?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (BookingPanel item in fpnBookings.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new BookingBLL().Delete(int.Parse(item.ID));
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " bookings has been deleted!");
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
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected bookings!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Booking> bookings = new List<Booking>();
                    int no = 0;
                    foreach (BookingPanel item in fpnBookings.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            bookings.Add(new BookingBLL().Retrieve(int.Parse(item.ID)));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<Booking>(bookings));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " bookings has been exported to excel!");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ShowBookings();
            }
            else
                ShowBookings(txtSearch.Text);
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowBookings();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowBookings();
        }

        private void BookingMenu_Load(object sender, EventArgs e)
        {
            ShowBookings();
        }
    }
}
