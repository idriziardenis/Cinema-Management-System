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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (pnlSideMenu.Width == 268)
            {
                pbLogo.Visible = false;
                pbLogoSmall.Visible = true;
                pnlSideMenu.Width = 47;
                int x = this.Size.Width;
                this.Size = new Size(x - 221, 641);
            }
            else
            {
                pbLogo.Visible = true;
                pbLogoSmall.Visible = false;
                pnlSideMenu.Width = 268;
                int x = this.Size.Width;
                this.Size = new Size(x + 221, 641);
            }
        }
        private void TransferFromFormToPanel(object Form)
        {
            if (this.pnlContent.Controls.Count > 0)
            {
                this.pnlContent.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            this.pnlContent.Tag = f;
            f.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblUserLogged.Text = UserSession.CurrentUser.FirstName + " " + UserSession.CurrentUser.LastName;
            TransferFromFormToPanel(new DashboardMenu());
            FullScreen(this, true);
        }
        private void FullScreen(Form target, bool enter)
        {
            if (enter)
            {
                target.WindowState = FormWindowState.Normal;
                target.FormBorderStyle = FormBorderStyle.None;
                target.WindowState = FormWindowState.Maximized;
            }
            else
            {
                target.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                target.WindowState = FormWindowState.Normal;
            }
        }

        private void btnHalls_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 447, 641);
            TransferFromFormToPanel(new HallMenu());
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 961, 641);
            TransferFromFormToPanel(new Movies());
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 769, 641);
            TransferFromFormToPanel(new SchedulesMenu());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 626, 641);
            TransferFromFormToPanel(new ClientsMenu());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 591, 641);
            TransferFromFormToPanel(new DashboardMenu());
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to logout?", "Logging out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                new Login().Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 575, 641);
            TransferFromFormToPanel(new EventMenu());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 769, 641);
            TransferFromFormToPanel(new BookingMenu());
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            this.Size = new Size(pnlSideMenu.Width + 769, 641);
            TransferFromFormToPanel(new TicketsMenu());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.HelpProvider hp = new System.Windows.Forms.HelpProvider();
            hp.HelpNamespace = @"C:\Users\Ardenis\Desktop\IT\MenaxhimiKinemase\MenaxhimiKinemase\CMS_Manual.chm";
            Help.ShowHelp(this, hp.HelpNamespace, HelpNavigator.Topic, "Navigimi.htm");
        }
    }
}
