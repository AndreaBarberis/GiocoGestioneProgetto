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
        /*VARIABILI DELL'UTENTE*/
        int qtaUtente = 3000000; //quantità truppe in generale
        int qtaRiservaUtente = 0; //quantità truppe in riserva
        int cmbUtente = 2; //combattività utente
        int discUtente = 2; //disciplina utente
        int trnUtente = 3; //turni x rifornimento ad utente
        int trnUtenteMalus = 0; //contatore per il malus dei turni dell'utente dopo aver selezionato l'azione di sabotaggio
        int ptnAzioni=0; //punti azioni utente
        int UtBonus = 3; //utilizzato per il bonus di Vittorio Emanuele
        string bonus; //per sapere il bonus scelto dall'utente
        /*VARIABILI BOT*/
        int qtaBot = 3000000; //quantità truppe in generale
        int qtaRiservaBot=0; //riserva del bot
        int fNord = 1000000; //quantità truppe fronte nord
        int fCentro = 1000000; //quantità truppe fronte centrale
        int fSud = 1000000; //quantità truppe fronte sud
        int cmbBot = 2; //combattività bot
        int discBot = 2; //disciplina bot
        int trnBot = 3; //turni x rifornimento bot
        int ptnAzioneBot = 0; //punti azioni bot
        int trnBotMalus = 2; //contatore per il malus dei turni del bot dopo aver selezzionato l'azione di sabotaggio
        Random rndfronte;
        Random rndsceltaIniz;
        Random rndQtaTruppe;
        
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
            if(bonus=="iniz") //se il bonus è quello dello Zar allora viene utilizzato subito
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
            playlist.PlayLooping(); //caricamento della playlist
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            playlist.Stop(); //stop della musica ed uscita
            this.Close();
        }

        private void btnOpzioni_Click(object sender, EventArgs e)
        {
            if(sound==1) //se la musica è attiva la tolgo
            {
                playlist.Stop();
                sound = 0;
            }
            else //se non è attiva la faccio ripartire
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
            frmAzioni A = new frmAzioni(ptnAzioni); //apro il form delle azioni con i punti disponibili
            A.ShowDialog();
            string az = A.azione(); //ritorno l'azione scelta
            ptnAzioni = A.punti(); //ritorno i punti rimasti
            if(az=="disc") //guardo l'azione scelta
            {
                if(cmbUtente<3)
                {
                    cmbUtente += 1;
                }
                if(discUtente<3)
                {
                    discUtente += 1;
                }
                switch (cmbUtente) //controllo per la parte grafica
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
                switch (discUtente) //controllo per la parte grafica
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
                    lbl1.Text = fNord.ToString();
                    lbl2.Text = fCentro.ToString();
                    lbl3.Text = fSud.ToString();
                    lstMessaggi.Items.Add("Truppe nemiche ora visibili su mappa");
                }
            }
        }

        private void btnSposta_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtSelezRiserve.Text)<=Convert.ToInt32(txtTruppeDisponibili.Text)) //se il numero scelto è possibile
            {
                switch (txtFronte.Text) 
                {
                    case "nord":
                        txtF1.Text = (Convert.ToInt32(txtF1.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte nord");
                        qtaRiservaUtente = qtaRiservaUtente - Convert.ToInt32(txtSelezRiserve.Text);
                        txtTruppeDisponibili.Text = (Convert.ToInt32(txtTruppeDisponibili.Text)-Convert.ToInt64(txtSelezRiserve.Text)).ToString();
                        break;
                    case "centro":
                        txtF2.Text = (Convert.ToInt32(txtF2.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte centrale");
                        qtaRiservaUtente = qtaRiservaUtente - Convert.ToInt32(txtSelezRiserve.Text);
                        txtTruppeDisponibili.Text = (Convert.ToInt32(txtTruppeDisponibili.Text) - Convert.ToInt64(txtSelezRiserve.Text)).ToString();
                        break;
                    case "sud":
                        txtF3.Text = (Convert.ToInt32(txtF3.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte sud");
                        qtaRiservaUtente = qtaRiservaUtente - Convert.ToInt32(txtSelezRiserve.Text);
                        txtTruppeDisponibili.Text = (Convert.ToInt32(txtTruppeDisponibili.Text) - Convert.ToInt64(txtSelezRiserve.Text)).ToString();
                        
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
            switch (bonus) //ha seconda del bonus che abbiamo
            {
                case "truppe":
                    txtTruppeDisponibili.Text = (Convert.ToInt32(txtTruppeDisponibili.Text) + 50000).ToString();
                    qtaRiservaUtente = Convert.ToInt32(txtTruppeDisponibili.Text);
                    lstMessaggi.Items.Add("Aggiunti "+50000+" soldati alla riserva");
                    UtBonus--;
                    if(UtBonus==0) //lo posso fare fino a 3 volte
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

        private void tmrBot_Tick(object sender, EventArgs e)
        {

        }

        private void btnPassa_Click(object sender, EventArgs e)
        {
            //foreach (var button in this.Controls.OfType<Button>())
            //{
            //    if(button.Name!="btnOpzioni" || button.Name!="btnEsci")
            //    {
            //        button.Enabled = false;
            //    }
            //    else
            //    {
            //        button.Enabled = true;
            //    }
               
            //}
            rndsceltaIniz = new Random();
            int rnd=rndsceltaIniz.Next(1, 4);
            switch (rnd) //azione
            {
                case 1: //spostamento
                    if(qtaRiservaBot>10000)
                    {
                        if (fNord < 50000)
                        {
                            fNord += rndQtaTruppe.Next(10000, qtaRiservaBot / 2);
                            lstMessaggi.Items.Add("Il nemico ha spostato delle truppe al fronte Nord");
                        }
                        else
                        {
                            if (fSud < 50000)
                            {
                                fSud+= rndQtaTruppe.Next(10000, qtaRiservaBot / 2);
                                lstMessaggi.Items.Add("Il nemico ha spostato delle truppe al fronte Sud");
                            }
                            else
                            {
                                fCentro += rndQtaTruppe.Next(10000, qtaRiservaBot / 2);
                                lstMessaggi.Items.Add("Il nemico ha spostato delle truppe al fronte Centrale");
                            }
                        }
                    }
                    break;
                case 2: //assalto
                    int qta=0;
                    int f=rndfronte.Next(1,4);
                    if(fNord>100000 || fSud>100000  || fCentro>100000)
                    {
                        if(f==1)
                        {
                            if(fNord>100000)
                            {
                               qta= rndQtaTruppe.Next(50000, fNord/2);
                            }
                           
                        }
                        else
                        {
                            if(f==2)
                            {
                                if (fSud > 100000)
                                {
                                    qta = rndQtaTruppe.Next(50000, fSud/2);
                                }
                            }
                            else
                            {
                                if (fCentro > 100000)
                                {
                                   qta = rndQtaTruppe.Next(50000, fCentro/2);
                                }
                            }
                        }
                       assaltoBot(f, qta);
                    }
                   break;
                case 3: //azioni
                    if (ptnAzioneBot >= 3)
                    {
                        ptnAzioneBot = ptnAzioneBot - 3;
                        trnUtente = trnUtente + 2;
                        trnUtenteMalus = 2;
                    }
                    else
                    {
                        if (ptnAzioneBot == 2)
                        {
                            if (cmbBot < 3)
                            {
                                cmbBot += 1;
                            }
                            if (discBot < 3)
                            {
                                discUtente += 1;
                            }
                        }

                    }
                    break;
                default:
                    break;
            }
            trnBot--;
            if(trnBot==0)
            {
                trnBot = 3;
                qtaRiservaBot += 50000;
            }
        }

        private void assaltoBot(int f, int qtaBot)
        {
            throw new NotImplementedException();
        }
    }
}
