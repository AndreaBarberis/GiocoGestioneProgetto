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
        int ptnAzioni=0;
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

        private void btnAzioni_Click(object sender, EventArgs e)
        {
            frmAzioni A = new frmAzioni(ptnAzioni);
            A.ShowDialog();
            string az = A.azione();
            if(az=="disc")
            {
                if(cmbUtente<3)
                {
                    cmbUtente += 1;
                }
                if(discUtente<3)
                {
                    discUtente += 1;
                }
                switch (cmbUtente)
                {
                    case 1:
                        txtComb.Text = "Bassa";
                        break;
                    case 2:
                        txtComb.Text = "Nella media";
                        break;
                    case 3:
                        txtComb.Text = "Alta";
                        break;
                    default:
                        break;
                }
                switch (discUtente)
                {
                    case 1:
                        txtDisc.Text = "Bassa";
                        break;
                    case 2:
                        txtDisc.Text = "Nella media";
                        break;
                    case 3:
                        txtDisc.Text = "Alta";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if(az=="treno")
                {
                    trnBot += 2;
                }
            }
        }
    }
}
