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
    public partial class CreateTicket : Form
    {
        Booking b;
        public CreateTicket(int chairid, int scheduleid)
        {
            InitializeComponent();
            b = new BookingBLL().RetrieveByChairAndSchedule(chairid, scheduleid);
            lblMovieTittle.Text = b.Schedule.Movie.Title;
            lblHall.Text = b.Schedule.Hall.Name;
            lblSeat.Text = b.Chair.Row + " , " + b.Chair.Column;
            if (b.Schedule.Hall.Technology.Type == "3D")
            {
                lblTech.Text = "3D";
            }
            else
            {
                lblTech.Text = "2D";
            }
            lblStartTime.Text = b.Schedule.StartTime.ToString("HH:mm");
            lblDuration.Text = b.Schedule.Movie.Duration.ToString();
            lblPaymentMethod.Text = "CASH";
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblCN.Text = b.Client.FirstName;
            lblLN.Text = b.Client.LastName;
            lblTickedID.Text = (new TicketBLL().Count() + 1).ToString();
            double movieprice = b.Schedule.Movie.Price;
            var events = new EventBLL().RetrieveALL();
            foreach (Event item in events)
            {
                if (item.EndDate > DateTime.Now)
                {
                    if (item.EventType.Type == "Daily")
                    {
                        if(item.Movie == b.Schedule.Movie)
                        {
                            movieprice = movieprice - movieprice * (item.Sales / 100);
                        }
                    }
                    else if (item.EventType.Type == "Weekly" && item.StartDate.DayOfWeek == DateTime.Now.DayOfWeek)
                    {
                        if (item.Movie == b.Schedule.Movie)
                        {
                            movieprice = movieprice - movieprice * (item.Sales / 100);
                        }
                    }
                    else if (item.EventType.Type == "Monthly")
                    {
                        while (item.StartDate < item.EndDate)
                        {
                            if (item.StartDate.Day == DateTime.Now.Day)
                            {
                                if (item.Movie == b.Schedule.Movie)
                                {
                                    movieprice = movieprice - movieprice * (item.Sales / 100);
                                }
                                item.StartDate.AddMonths(1);
                            }
                        }
                    }
                    else if (item.EventType.Type == "Yearly")
                    {
                        while (item.StartDate < item.EndDate)
                        {
                            if (item.StartDate.Day == DateTime.Now.Day)
                            {
                                if (item.Movie == b.Schedule.Movie)
                                {
                                    movieprice = movieprice - movieprice * (item.Sales / 100);
                                }
                                item.StartDate.AddYears(1);
                            }
                        }
                    }
                }
            }
            lblMoviePrice.Text = movieprice.ToString() + "$";
            lblVAT.Text = "+ " + (b.Schedule.Movie.Price * 0.18).ToString() + "$";
            lblTechnology.Text = ((Func<string>)(() => { if (lblTech.Text == "3D") { return "+ " + b.Schedule.Movie.Price * 0.25 + "$"; } else { return "+ 0" + "$"; } }))();
            double total = movieprice + ((Func<double>)(() => { if (lblTech.Text == "3D") { return b.Schedule.Movie.Price * 0.25; } else { return 0; } }))() + (b.Schedule.Movie.Price * 0.18);
            lblTOTAL.Text = total.ToString() + " $";
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            var all = new TicketBLL().RetrieveALL();
            bool exist = false;
            foreach (Ticket item in all)
            {
                if (item.Booking.Schedule.ID == b.Schedule.ID && item.Booking.Chair.ID == b.Chair.ID)
                    exist = true;
            }
            if(exist == true)
            {
                MessageBox.Show("Ticket is already created!");
                this.Close();
            }
            else
            {
                new TicketBLL().Create(new Ticket() { Cinema = new Cinema() { ID = 1 }, Booking = b, Payment = new Payment() { ID = 1 }, Date = DateTime.Now, Price = double.Parse(lblTOTAL.Text.Substring(0, lblTOTAL.Text.Length - 2)), VAT = 0.18, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } }); ; ;
                MessageBox.Show("You successfully created ticket!");
                this.Close();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
