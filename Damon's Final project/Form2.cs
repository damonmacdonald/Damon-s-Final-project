using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damon_s_Final_project
{
    public partial class frmRules : Form
    {
        public frmRules()
        {
            InitializeComponent();
        }

        private void lblRulesTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlay frmPlay = new frmPlay();
            this.Hide();
            frmPlay.ShowDialog();
            this.Show();
            this.Dispose();
        }
    }
}
