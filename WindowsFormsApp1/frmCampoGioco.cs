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
        int qtaRiservaUtente = 0;
        int cmbUtente = 2;
        int discUtente = 2;
        int trnUtente = 3;
        int ptnAzioni=0;
        int UtBonus = 3;
        int qtaBot = 3000000;
        int F1 = 1000000;
        int F2 = 1000000;
        int F3 = 1000000;
        int cmbBot = 2;
        int discBot = 2;
        int trnBot = 3;
        int trnBotMalus = 2;
        string bonus;
        SoundPlayer playlist = new SoundPlayer(@"playlist.wav");
        int sound = 3;
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
                txtTruppeDisponibili.Text = 500000.ToString();
                qtaRiservaUtente = Convert.ToInt32(txtTruppeDisponibili.Text);
                discUtente = 1;
                txtDisc.Text = "Bassa";
                txtComb.Text = "nella media";
               
            }
            else
            {
                txtTruppeDisponibili.Text = 0.ToString();
                txtComb.Text = "Nella media";
                txtDisc.Text = "Nella media";
            }
            txtF1.Text = (qtaUtente / 3).ToString();
            txtF2.Text = (qtaUtente / 3).ToString();
            txtF3.Text = (qtaUtente / 3).ToString();
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
            ptnAzioni = A.punti();
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
                lstMessaggi.Items.Add("Disciplina e combattività aumentati");
            }
            else
            {
                if(az=="treno")
                {
                    trnBot += 2;
                    lstMessaggi.Items.Add("Turni più lenti per il nemico");
                }
                else if(az=="spia")
                {
                    lbl1.Text = F1.ToString();
                    lbl2.Text = F2.ToString();
                    lbl3.Text = F3.ToString();
                    lstMessaggi.Items.Add("Truppe nemiche ora visibili su mappa");
                }
            }
        }

        private void btnSposta_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtSelezRiserve.Text)<=Convert.ToInt32(txtTruppeDisponibili.Text))
            {
                switch (txtFronte.Text)
                {
                    case "nord":
                        txtF1.Text = (Convert.ToInt32(txtF1.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte nord");
                        txtTruppeDisponibili.Text = (Convert.ToInt32(txtTruppeDisponibili.Text)-Convert.ToInt64(txtSelezRiserve.Text)).ToString();
                        break;
                    case "centro":
                        txtF2.Text = (Convert.ToInt32(txtF2.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte centrale");
                        break;
                    case "sud":
                        txtF3.Text = (Convert.ToInt32(txtF3.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte sud");
                        break;
                    default:
                        MessageBox.Show("Selezionare fronte: nord - centro - sud");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Quantità truppe non disponibile");
            }
          
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            switch (bonus)
            {
                case "truppe":
                    txtTruppeDisponibili.Text = (Convert.ToInt32(txtTruppeDisponibili.Text) + 50000).ToString();
                    qtaRiservaUtente = Convert.ToInt32(txtTruppeDisponibili.Text);
                    lstMessaggi.Items.Add("Aggiunti "+50000+" soldati alla riserva");
                    UtBonus--;
                    if(UtBonus==0)
                    {
                        btnBonus.Enabled = false;
                    }
                    break;
                case "rif":
                    trnUtente--;
                    lstMessaggi.Items.Add("Rifornimenti di truppe più veloci");
                    btnBonus.Enabled = false;
                    break;
                case "comb":
                    cmbUtente++;
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
                    lstMessaggi.Items.Add("Combattività aumentata");
                    btnBonus.Enabled = false;
                    break;
                case "az":
                    ptnAzioni=ptnAzioni+2;
                    lstMessaggi.Items.Add("Punti azioni aggiunti");
                    btnBonus.Enabled = false;
                    break;
                default:
                    lstMessaggi.Items.Add("Bonus non disponibile");
                    btnBonus.Enabled = false;
                    break;
            }
           
        }
    }
}
