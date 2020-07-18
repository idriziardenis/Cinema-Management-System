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
    
    public partial class EditMovie : Form
    {
        public Movie m;
        public EditMovie(int id)
        {
            m = new MovieBLL().Retrieve(id);
            InitializeComponent();
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            var categorys = new CategoryBLL().RetrieveALL();
            foreach (var category in categorys)
            {
                cbCategory.Items.Add(category);
            }
            lblEdit.Text += m.ID.ToString(); ;
            txtDescription.Text = m.Description;
            txtImagePath.Text = m.ImagePath;
            txtMinimumAge.Text = m.MinimumAge.ToString();
            txtPrice.Text = m.Price.ToString();
            txtTrailerLink.Text = m.TrailerLink;
            cbCategory.SelectedItem = m.Category;
            cbStatus.Text = m.isActive.ToString();
            numericDuration.Value = m.Duration;
            dtReleaseDate.Value = m.ReleaseDate;
            txtTitle.Text = m.Title;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m.Title = txtTitle.Text;
            m.Description = txtDescription.Text;
            m.ImagePath = txtImagePath.Text;
            m.MinimumAge = int.Parse(txtMinimumAge.Text);
            m.Price = double.Parse(txtPrice.Text);
            m.TrailerLink = txtTrailerLink.Text;
            m.Category = (CinemaManagement.BO.Category)cbCategory.SelectedItem;
            m.isActive = ((Func<bool>)(() => { if (cbStatus.Text == "Active") { return true; } else { return false; } }))();
            m.Duration = (int)numericDuration.Value;
            m.ReleaseDate = dtReleaseDate.Value;
            if (m.BaseAuditObject == null)
            {
                m.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                m.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new MovieBLL().Update(m);
            MessageBox.Show("Changes successfully saved!");
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMinimumAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
    }
}
