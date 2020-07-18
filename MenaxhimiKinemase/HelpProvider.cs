using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKinemase
{
    public static class HelpProvider
    {
        public static void GetHelpProvider(Form frm, string topic)
        {
            Help.ShowHelp(frm, "CMS_Manual.chm", HelpNavigator.Topic, topic);
        }
    }
}
