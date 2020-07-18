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
    public partial class ActiveEventsPanel : UserControl
    {
        public ActiveEventsPanel()
        {
            InitializeComponent();
        }

        public string EventTittle { get { return lblEventTitle.Text; } set { lblEventTitle.Text = value; } }
        public string EventDuration { get { return lblDuration.Text; } set { lblDuration.Text = value; } }
        public string EventSale { get { return lblSale.Text; } set { lblSale.Text = value; } }
        public string EventType { get { return lblType.Text; } set { lblType.Text = value; } }

    }
}
