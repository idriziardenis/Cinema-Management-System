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
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace MenaxhimiKinemase
{
    public partial class AddNewEvent : Form
    {
        
        public AddNewEvent()
        {
            InitializeComponent();
        }

        private void AddNewEvent_Load(object sender, EventArgs e)
        {
            var EventTypes = new EventTypeBLL().RetrieveALL();
            foreach (var et in EventTypes)
            {
                cbType.Items.Add(et);
            }
            var Movies = new MovieBLL().RetrieveALL();
            foreach (var item in Movies)
            {
                cbMovies.Items.Add(item);
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            browseImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (browseImage.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = browseImage.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var MovieBLL = new MovieBLL();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                new EventBLL().Create(new Event() { Movie = (Movie)cbMovies.SelectedItem, Title = txtTittle.Text, Sales = (double)numericSales.Value, Description = txtDescription.Text, ImagePath = txtImagePath.Text, StartDate = dtStartDate.Value, EndDate = dtEndDate.Value, EventType = (EventType)cbType.SelectedItem, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } });
                DialogResult result = MessageBox.Show("Event sucessfully added! \n Do you want to add another event?", "Event sucessfully added!", MessageBoxButtons.YesNo);
                var movie = (Movie)cbMovies.SelectedItem;
                try
                {
                    //List<Task> tasks = new List<Task>();
                    
                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("ardenisdrizi@gmail.com", "ardenisi00"),
                        EnableSsl = true,
                    };
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress("ardenisdrizi@gmail.com"),
                        Subject = "New event is happening right now! DONT MISS IT!",
                        Body = $"<h1>Event: {txtTittle.Text}</h1><br><h2>Discount: {(double)numericSales.Value} %</h2><br><h2>Movie: {movie.Title}</h2><br><h2>Start: {dtStartDate.Value.ToString("dd-MM-yyyy")}</h2><br><h2> End: {dtEndDate.Value.ToString("dd-MM-yyyy")}</h2>",
                        IsBodyHtml = true,
                    };
                    var clients = new ClientBLL().RetrieveALL();

                    foreach (var client in clients)
                    {
                        mailMessage.To.Add(client.UserName);
                        smtpClient.Send(mailMessage);
                    }
                    
                }
                catch (Exception ex)
                {
                    string a = ex.Message;
                }
                if (result == DialogResult.Yes)
                {
                    txtTittle.Text = txtDescription.Text = txtImagePath.Text = "";
                    dtStartDate.Value = DateTime.Now;
                    dtEndDate.Value = DateTime.Now;
                    cbType.SelectedIndex = -1;
                    cbMovies.SelectedIndex = -1;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Canceling!", $"Are you sure that you want to cancel this operation?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operation canceled!");
            }
        }

        private void txtTittle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTittle.Text))
            {
                e.Cancel = true;
                txtTittle.Focus();
                errorProvider1.SetError(txtTittle, "Title cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTittle, null);
            }
        }

        private void numericSales_Validating(object sender, CancelEventArgs e)
        {
            if (numericSales.Value < 0)
            {
                e.Cancel = true;
                numericSales.Focus();
                errorProvider1.SetError(numericSales, "Sales cannot be less than 0!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericSales, null);
            }
        }

        private void txtImagePath_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtImagePath.Text))
            {
                e.Cancel = true;
                txtImagePath.Focus();
                errorProvider1.SetError(txtImagePath, "Image Path cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtImagePath, null);
            }
        }

        private void dtStartDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtStartDate.Value == DateTime.Now)
            {
                e.Cancel = true;
                dtStartDate.Focus();
                errorProvider1.SetError(dtStartDate, "Start Date cannot be default!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtStartDate, null);
            }
        }

        private void dtEndDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtEndDate.Value == DateTime.Now)
            {
                e.Cancel = true;
                dtEndDate.Focus();
                errorProvider1.SetError(dtEndDate, "End Date cannot be default!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtEndDate, null);
            }
        }

        private void cbType_Validating(object sender, CancelEventArgs e)
        {
            if (cbType.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbType.Focus();
                errorProvider1.SetError(cbType, "Event Type cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbType, null);
            }
        }

        private void cbMovies_Validating(object sender, CancelEventArgs e)
        {
            if (cbMovies.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbMovies.Focus();
                errorProvider1.SetError(cbMovies, "Movie cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbMovies, null);
            }
        }
    }
}
