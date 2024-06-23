using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damon_s_Final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sound;
            sound = new SoundPlayer(Properties.Resources.Starting_Theme__wav_);
            sound.Play();
            sound.PlayLooping();
        }
        private void btnRules_Click_1(object sender, EventArgs e)
        {
            frmRules frmRules = new frmRules();
            this.Hide();
            frmRules.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            frmPlay frmPlay = new frmPlay();
            this.Hide();
            frmPlay.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
