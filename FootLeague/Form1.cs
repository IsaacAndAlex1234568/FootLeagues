using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootLeague
{
    public partial class fm_loading : Form
    {
        public fm_loading()
        {
            InitializeComponent();
        }

        private void fm_loading_Load(object sender, EventArgs e)
        {
            tm_loading.Enabled = true;
        }

        private void tm_loading_Tick(object sender, EventArgs e)
        {
            tm_loading.Enabled = false;
            Form fm_profile = new fm_profile();
            fm_profile.Visible = true;
            this.Hide();

        }
    }
}
