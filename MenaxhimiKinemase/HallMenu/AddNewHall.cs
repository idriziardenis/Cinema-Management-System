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
    public partial class AddNewHall : Form
    {
        public AddNewHall()
        {
            InitializeComponent();
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                new HallBLL().Create(new Hall() { Name = txtName.Text, NoColumn = (int)numericColumns.Value, NoRow = (int)numericRows.Value, Technology = (Technology)cbTechnology.SelectedItem, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } });
                var bll = new ChairBLL();
                for (int i = 1; i < (int)numericRows.Value + 1; i++)
                {
                    for (int j = 1; j < (int)numericColumns.Value + 1; j++)
                    {
                        if (!bll.isCreated(i, j))
                        {
                            bll.Create(new Chair() { Row = i, Column = j, isBooked = false, BaseAuditObject = new BaseAudit() { InsertBy = UserSession.CurrentUser.ID, InsertDate = DateTime.Now } });
                        }
                    }
                }
                DialogResult result = MessageBox.Show("Hall sucessfully added! \n Do you want to add another Hall?", "Hall sucessfully added!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtName.Text = "";
                    numericColumns.Value = 0;
                    numericRows.Value = 0;
                    cbTechnology.SelectedIndex = -1;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewHall_Load(object sender, EventArgs e)
        {
            var techs = new TechnologyBLL().RetrieveALL();
            foreach (var item in techs)
            {
                cbTechnology.Items.Add(item);
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

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Name cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }

        private void cbTechnology_Validating(object sender, CancelEventArgs e)
        {
            if (cbTechnology.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbTechnology.Focus();
                errorProvider1.SetError(cbTechnology, "Technology cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbTechnology, null);
            }
        }

        private void numericRows_Validating(object sender, CancelEventArgs e)
        {
            if (numericRows.Value < 0)
            {
                e.Cancel = true;
                numericRows.Focus();
                errorProvider1.SetError(numericRows, "Rows cannot be less than 0!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericRows, null);
            }
        }

        private void numericColumns_Validating(object sender, CancelEventArgs e)
        {
            if (numericColumns.Value < 0)
            {
                e.Cancel = true;
                numericColumns.Focus();
                errorProvider1.SetError(numericColumns, "Columns cannot be less than 0!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericColumns, null);
            }
        }
    }
}
