using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKinemase
{
    public partial class ShowTimePanel : UserControl
    {
        public ShowTimePanel()
        {
            InitializeComponent();
        }

        public string ShowTimeDate { get { return lblDate.Text; } set { lblDate.Text = value; } }
        public string ShowTimeHall { get { return lblHall.Text; } set { lblHall.Text = value; } }
        public string ShowTimeTime { get { return lblTime.Text; } set { lblTime.Text = value; } }
    }
}
