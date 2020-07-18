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
    public partial class EditHall : Form
    {
        Hall h;
        public EditHall(int id)
        {
            h = new HallBLL().Retrieve(id);
            InitializeComponent();
        }

        private void EditHall_Load(object sender, EventArgs e)
        {
            lblEdit.Text += h.ID;
            txtName.Text = h.Name;
            var techs = new TechnologyBLL().RetrieveALL();
            foreach (var item in techs)
            {
                cbTechnology.Items.Add(item);
            }
            cbTechnology.Text = h.Technology.Type;
            cbTechnology.SelectedItem = h.Technology;
            numericRows.Value = h.NoRow;
            numericColumns.Value = h.NoColumn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            h.Name = txtName.Text;
            h.Technology = (Technology)cbTechnology.SelectedItem;
            h.NoColumn = (int)numericColumns.Value;
            h.NoRow = (int)numericRows.Value;
            if (h.BaseAuditObject == null)
            {
                h.BaseAuditObject = new BaseAudit() { UpdateBy = UserSession.CurrentUser.ID };
            }
            else
            {
                h.BaseAuditObject.UpdateBy = UserSession.CurrentUser.ID;
            }
            new HallBLL().Update(h);
            MessageBox.Show("Changes successfully saved!");
            this.Close();
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
