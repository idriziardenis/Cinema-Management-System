using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BO;
using CinemaManagement.BLL;
namespace MenaxhimiKinemase
{
    public partial class AddNewMovieForm : Form
    {
        public AddNewMovieForm()
        {
            InitializeComponent();
        }

        private void btnAddCast_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                new MovieBLL().Create(new Movie() { Title = txtTittle.Text, Description = txtDescription.Text, ImagePath = txtImagePath.Text, ReleaseDate = dtReleaseDate.Value, isActive = GetStatus(), Price = double.Parse(txtPrice.Text), Duration = (int)numericDuration.Value, TrailerLink = txtTrailerLink.Text, MinimumAge = int.Parse(txtMinimumAge.Text), Category = (Category)cbCategory.SelectedItem, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } });
                DialogResult result = MessageBox.Show("Movie sucessfully added! \n Do you want to add another movie?", "Movie sucessfully added!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtTittle.Text = txtDescription.Text = txtImagePath.Text = txtPrice.Text = txtTrailerLink.Text = txtTrailerLink.Text = txtMinimumAge.Text = "";
                    dtReleaseDate.Value = DateTime.Now;
                    cbStatus.SelectedIndex = -1;
                    cbCategory.SelectedIndex = -1;
                    numericDuration.Value = 0;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        private bool GetStatus()
        {
            if (cbStatus.Text == "Active")
                return true;
            else
                return false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            browseimage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (browseimage.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = browseimage.FileName;
            }
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

        private void AddNewMovieForm_Load(object sender, EventArgs e)
        {
            var categorys = new CategoryBLL().RetrieveALL();
            foreach (var category in categorys)
            {
                cbCategory.Items.Add(category);
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

        private void dtReleaseDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtReleaseDate.Value == DateTime.Now)
            {
                e.Cancel = true;
                dtReleaseDate.Focus();
                errorProvider1.SetError(dtReleaseDate, "Release Date cannot be default!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtReleaseDate, null);
            }
        }

        private void cbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (cbStatus.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbStatus.Focus();
                errorProvider1.SetError(cbStatus, "Status cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbStatus, null);
            }
        }

        private void cbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategory.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbCategory.Focus();
                errorProvider1.SetError(cbCategory, "Category cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbCategory, null);
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                e.Cancel = true;
                txtPrice.Focus();
                errorProvider1.SetError(txtPrice, "Price cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrice, null);
            }
        }

        private void numericDuration_Validating(object sender, CancelEventArgs e)
        {
            if (numericDuration.Value < 0)
            {
                e.Cancel = true;
                numericDuration.Focus();
                errorProvider1.SetError(numericDuration, "Sales cannot be less than 0!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericDuration, null);
            }
        }

        private void txtTrailerLink_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTrailerLink.Text))
            {
                e.Cancel = true;
                txtTrailerLink.Focus();
                errorProvider1.SetError(txtTrailerLink, "Trailer Link cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTrailerLink, null);
            }
        }

        private void txtMinimumAge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMinimumAge.Text))
            {
                e.Cancel = true;
                txtMinimumAge.Focus();
                errorProvider1.SetError(txtMinimumAge, "Minimum Age cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMinimumAge, null);
            }
        }
    }
}
