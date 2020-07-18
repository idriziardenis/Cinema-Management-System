using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BO;
using CinemaManagement.BLL;

namespace MenaxhimiKinemase
{
    public partial class MoviePanel : UserControl
    {
        int X = 0, Y = 0;
        public MoviePanel(int x, int y)
        {
            InitializeComponent();
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.X = x;
            this.Y = this.Size.Height;
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
        public Image MovieLogo
        {
            get { return pbMoviePhoto.Image; }
            set { pbMoviePhoto.Image = value; }
        }
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }
        public string ReleaseDate
        {
            get { return lblReleaseDate.Text; }
            set { lblReleaseDate.Text = value; }
        }
        public string Category
        {
            get { return lblCategory.Text; }
            set { lblCategory.Text = value; }
        }
        public ComboBox Status
        {
            get { return cbStatus; }
            set { cbStatus = value; }
        }
        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public string Duration
        {
            get { return lblDuration.Text; }
            set { lblDuration.Text = value; }
        }
        public string TrailerLink { get; set; }
        public string MinimumAge
        {
            get { return lblMinimumAge.Text; }
            set { lblMinimumAge.Text = value; }
        }
        private void lblTrailer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTrailer.LinkVisited = true;
            System.Diagnostics.Process.Start(TrailerLink);
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            var bll = new MovieBLL();
            int movieId = int.Parse(lblID.Text);
            Movie m = bll.Retrieve(movieId);
            m.isActive = ((Func<bool>)(() => { if (cbStatus.Text == "Active") { return true; } else { return false; } }))();
            if(m.BaseAuditObject == null)
            {
                m.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                m.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            bll.Update(m);
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            new EditMovie(int.Parse(lblID.Text)).ShowDialog();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lblID.Text);
            DialogResult dialogResult = MessageBox.Show("Deleting movie with id " + ID, $"Are you sure that you want to delete this movie?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new MovieBLL().Delete(ID);
                MessageBox.Show("Deleted sucessfully!");
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deleting canceled!");
            }
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            new Info(Info.Record.Movie, int.Parse(lblID.Text)).ShowDialog();
        }

        private void MoviePanel_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
