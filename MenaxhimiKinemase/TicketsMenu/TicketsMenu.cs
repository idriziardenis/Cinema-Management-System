using CinemaManagement.BLL;
using CinemaManagement.BO;
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
    public partial class TicketsMenu : Form
    {
        List<Ticket> tickets;
        public TicketsMenu()
        {
            InitializeComponent();
        }

        private void TicketsMenu_Load(object sender, EventArgs e)
        {
            ShowTickets();
        }

        private void ShowTickets()
        {
            if (fpnTickets.Controls.Count > 0)
            {
                fpnTickets.Controls.Clear();
            }
            tickets = new TicketBLL().RetrieveALL();
            TicketsPanel[] ticket = new TicketsPanel[tickets.Count];
            for (int i = 0; i < ticket.Length; i++)
            {
                ticket[i] = new TicketsPanel(table.Size.Width, table.Size.Height);
                ticket[i].ID = tickets[i].ID.ToString();
                ticket[i].Cinema = "Cineflexx";
                ticket[i].BookingID = tickets[i].Booking.ID.ToString();
                ticket[i].Payment = "CASH";
                ticket[i].Price = tickets[i].Price.ToString() + " $";
                ticket[i].Date = tickets[i].Date.ToString("dd-MM-yyyy");
                ticket[i].VAT = tickets[i].VAT.ToString();
                fpnTickets.Controls.Add(ticket[i]);
            }
        }

        private void ShowTickets(string bookingid)
        {
            if (fpnTickets.Controls.Count > 0)
            {
                fpnTickets.Controls.Clear();
            }
            if (this.tickets == null)
            {
                this.tickets = new TicketBLL().RetrieveALL();
            }

            var all = this.tickets;

            List<Ticket> tickets = new List<Ticket>();
            foreach (var item in all)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Booking.ID.ToString(), bookingid))
                {
                    tickets.Add(item);
                }
            }

            tickets = new TicketBLL().RetrieveALL();
            TicketsPanel[] ticket = new TicketsPanel[tickets.Count];
            for (int i = 0; i < ticket.Length; i++)
            {
                ticket[i] = new TicketsPanel(table.Size.Width, table.Size.Height);
                ticket[i].ID = tickets[i].ID.ToString();
                ticket[i].Cinema = "Cineflexx";
                ticket[i].BookingID = tickets[i].Booking.ID.ToString();
                ticket[i].Payment = "CASH";
                ticket[i].Price = tickets[i].Price.ToString();
                ticket[i].Date = tickets[i].Date.ToString("dd-MM-yyyy");
                ticket[i].VAT = tickets[i].VAT.ToString();
                fpnTickets.Controls.Add(ticket[i]);
            }
        }

        private void chCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked == true)
            {
                foreach (TicketsPanel item in fpnTickets.Controls)
                {
                    item.Check.Checked = true;

                }
            }
            else
            {
                foreach (TicketsPanel item in fpnTickets.Controls)
                {
                    item.Check.Checked = false;
                }
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.Text == "Delete Selected")
            {
                DialogResult dialogResult = MessageBox.Show("Deleting selected tickets!", $"Are you sure that you want to delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int no = 0;
                    foreach (TicketsPanel item in fpnTickets.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            new TicketBLL().Delete(int.Parse(item.ID));
                            no++;
                        }
                    }
                    if (no > 0)
                    {
                        MessageBox.Show(no + " schedulues has been tickets!");
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
            else if(cbAction.Text == "Export to Excel")
            {
                DialogResult dialogResult = MessageBox.Show("Exporting to Excel selected tickets!", $"Are you sure that you want to Export to Excel?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<Ticket> tickets = new List<Ticket>();
                    int no = 0;
                    foreach (TicketsPanel item in fpnTickets.Controls)
                    {
                        if (item.Check.Checked == true)
                        {
                            tickets.Add(new TicketBLL().Retrieve(int.Parse(item.ID)));
                            no++;
                        }
                    }
                    ExcelExport.GenerateExcel(ExcelExport.ConvertToDataTable<Ticket>(tickets));
                    if (no > 0)
                    {
                        MessageBox.Show(no + " tickets has been exported to excel!");
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
                ShowTickets();
            }
            else
                ShowTickets(txtSearch.Text);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowTickets();
        }

        private void table_SizeChanged(object sender, EventArgs e)
        {
            ShowTickets();
        }
    }
}
