using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin
{
    public partial class VersionInfo : Form
    {
        public VersionInfo()
        {
            InitializeComponent();
        }

        private void lblTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/QWERTY_KY");
        }
    }
}
