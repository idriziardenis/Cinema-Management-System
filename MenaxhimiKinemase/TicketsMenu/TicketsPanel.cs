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

namespace MenaxhimiKinemase
{
    public partial class TicketsPanel : UserControl
    {
        int X = 0, Y = 0;
        public TicketsPanel(int x, int y)
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
        public string Cinema
        {
            get { return lblCinema.Text; }
            set { lblCinema.Text = value; }
        }
        public string BookingID
        {
            get { return lblBookingID.Text; }
            set { lblBookingID.Text = value; }
        }
        public string Payment
        {
            get { return lblPayment.Text; }
            set { lblPayment.Text = value; }
        }
        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public string Date
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }
        public string VAT
        {
            get { return lblVAT.Text; }
            set { lblVAT.Text = value; }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lblID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting ticket with id " + ID, $"Are you sure that you want to delete this ticket?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new TicketBLL().Delete(ID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void TicketsPanel_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.Ticket, int.Parse(lblID.Text)).ShowDialog();
        }
    }
}
