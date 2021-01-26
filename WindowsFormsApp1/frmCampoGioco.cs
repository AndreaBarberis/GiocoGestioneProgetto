using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCampoGioco : Form
    {
        int qtaUtente = 3000000;
        int cmbUtente = 2;
        int discUtente = 2;
        int trnUtente = 3;
        int qtaBot = 3000000;
        int cmbBot = 2;
        int discBot = 2;
        int trnBot = 3;
        string bonus;
        SoundPlayer playlist = new SoundPlayer(@"playlist.wav");
        int sound = 1;
        public frmCampoGioco()
        {
            InitializeComponent();
        }
        public frmCampoGioco(string typeBonus)
        {
            InitializeComponent();
            bonus = typeBonus;
            if(bonus=="iniz")
            {
                qtaUtente += 500000;
                txtTruppeDisponibili.Text = qtaUtente.ToString();
                discUtente = 1;
                txtDisc.Text = "Bassa";
                txtComb.Text = "nella media";
            }
            else
            {
                txtTruppeDisponibili.Text = qtaUtente.ToString();
                txtComb.Text = "Nella media";
                txtDisc.Text = "Nella media";
            }
        }

        private void frmCampoGioco_Load(object sender, EventArgs e)
        {
            playlist.PlayLooping();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            playlist.Stop();
            this.Close();
        }

        private void btnOpzioni_Click(object sender, EventArgs e)
        {
            if(sound==1)
            {
                playlist.Stop();
                sound = 0;
            }
            else
            {
                playlist.PlaySync();
                sound = 1;
            }
        }

        private void frmCampoGioco_FormClosing(object sender, FormClosingEventArgs e)
        {
            playlist.Stop();
        }
    }
}
