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
    public partial class TestingPurposes : Form
    {
        public TestingPurposes()
        {
            InitializeComponent();
        }

        public DataGridView Test<T>(List<T> collection)
        {
            DataGridView grid = new DataGridView();
            var source = new BindingSource();
            source.DataSource = collection;
            grid.DataSource = source;
            return grid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = new TechnologyBLL().RetrieveALL();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TestingPurposes_Load(object sender, EventArgs e)
        {

        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
