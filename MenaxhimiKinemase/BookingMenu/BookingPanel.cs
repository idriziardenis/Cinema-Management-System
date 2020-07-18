using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BLL;
using CinemaManagement.BO;

namespace MenaxhimiKinemase
{
    public partial class BookingPanel : UserControl
    {
        int X = 0, Y = 0;
        public BookingPanel(int x, int y)
        {
            InitializeComponent();
            this.X = x;
            this.Y = y;
        }
        public CheckBox Check
        {
            get { return chCheck; }
            set { chCheck = value; }
        }
        public string ID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }
        public string MovieName
        {
            get { return lblMovieName.Text; }
            set { lblMovieName.Text = value; }
        }
        public string HallName
        {
            get { return lblHallName.Text; }
            set { lblHallName.Text = value; }
        }
        public string StartTime
        {
            get { return lblStartTime.Text; }
            set { lblStartTime.Text = value; }
        }
        public string EndTime
        {
            get { return lblEndTime.Text; }
            set { lblEndTime.Text = value; }
        }
        public string ClientName
        {
            get { return lblClientName.Text; }
            set { lblClientName.Text = value; }
        }
        public string Chair
        {
            get { return lblChair.Text; }
            set { lblChair.Text = value; }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lblID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting booking with id " + ID, $"Are you sure that you want to delete this booking?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new BookingBLL().Delete(ID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void BookingPanel_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
        }

        private void pbBook_Click(object sender, EventArgs e)
        {
            int col = new BookingBLL().Retrieve(int.Parse(lblID.Text)).Chair.Column;
            int row = new BookingBLL().Retrieve(int.Parse(lblID.Text)).Chair.Row;
            Chair c = new ChairBLL().RetrieveByRC(row, col);
            Booking b = new BookingBLL().Retrieve(int.Parse(lblID.Text));
            new CreateTicket(c.ID,b.Schedule.ID).ShowDialog();
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.Booking, int.Parse(lblID.Text)).ShowDialog();
        }
    }
}
