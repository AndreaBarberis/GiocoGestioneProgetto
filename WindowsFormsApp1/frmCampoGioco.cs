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
        int trnUtenteMalus =2; //contatore per il malus dei turni dell'utente dopo aver selezionato l'azione di sabotaggio
        int trnUtenteBonus = 2;
        int ptnAzioni=0; //punti azioni utente
        int UtBonus = 3; //utilizzato per il bonus di Vittorio Emanuele
        string bonus; //per sapere il bonus scelto dall'utente
        bool malusUtente = false;
        bool utenteBonus = false;
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
        bool malusBot = false;
        int trnBotMalus = 2; //contatore per il malus dei turni del bot dopo aver selezzionato l'azione di sabotaggio
        Random rndfronte = new Random();
        Random rndsceltaIniz=new Random();
        Random rndQtaTruppe=new Random();
        
        SoundPlayer playlist = new SoundPlayer(@"playlist.wav");
        SoundPlayer morse = new SoundPlayer(@"morse.wav");
        int sound = 1;
        int messageSound = 0;
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
          playlist.Play(); //caricamento della playlist
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
                messageSound = 1;
            }
            else //se non è attiva la faccio ripartire
            {
                playlist.Play();
                sound = 1;
                messageSound = 0;
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
                playSuono();    
                lstMessaggi.Items.Add("Disciplina e combattività aumentati");
            }
            else
            {
                if(az=="treno")
                {
                    trnBot += 2;
                    malusBot = true;
                    playSuono();
                    lstMessaggi.Items.Add("Turni più lenti per il nemico");
                }
                else if(az=="spia")
                {
                    lbl1.Text = fNord.ToString();
                    lbl2.Text = fCentro.ToString();
                    lbl3.Text = fSud.ToString();
                    playSuono();
                    lstMessaggi.Items.Add("Truppe nemiche ora visibili su mappa");
                }
            }
        }

       

        private void btnSposta_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtSelezRiserve.Text)<=Convert.ToInt32(txtTruppeDisponibili.Text)) //se il numero scelto è possibile
            {
                switch (cmbFronte.SelectedItem.ToString()) 
                {
                    case "Nord":
                        txtF1.Text = (Convert.ToInt32(txtF1.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte nord");
                        playSuono();
                        qtaRiservaUtente = qtaRiservaUtente - Convert.ToInt32(txtSelezRiserve.Text);
                        txtTruppeDisponibili.Text = qtaRiservaUtente.ToString();
                        break;
                    case "Centro":
                        txtF2.Text = (Convert.ToInt32(txtF2.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte centrale");
                        playSuono();
                        qtaRiservaUtente = qtaRiservaUtente - Convert.ToInt32(txtSelezRiserve.Text);
                        txtTruppeDisponibili.Text = qtaRiservaUtente.ToString();
                        break;
                    case "Sud":
                        txtF3.Text = (Convert.ToInt32(txtF3.Text) + Convert.ToInt32(txtSelezRiserve.Text)).ToString();
                        lstMessaggi.Items.Add("Sono state spostate " + txtSelezRiserve.Text + " truppe al Fronte sud");
                        playSuono();
                        qtaRiservaUtente = qtaRiservaUtente - Convert.ToInt32(txtSelezRiserve.Text);
                        txtTruppeDisponibili.Text = qtaRiservaUtente.ToString();

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
                    playSuono();
                    UtBonus--;
                    if(UtBonus==0) //lo posso fare fino a 3 volte
                    {
                        btnBonus.Enabled = false;
                    }
                    break;
                case "rif":
                    trnUtente--;
                    lstMessaggi.Items.Add("Rifornimenti di truppe più veloci");
                    playSuono();
                    btnBonus.Enabled = false;
                    utenteBonus = true;
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
                    playSuono();
                    btnBonus.Enabled = false;
                    break;
                case "az":
                    ptnAzioni=ptnAzioni+2;
                    lstMessaggi.Items.Add("Punti azioni aggiunti");
                    playSuono();
                    btnBonus.Enabled = false;
                    break;
                default:
                    lstMessaggi.Items.Add("Bonus non disponibile");
                    playSuono();
                    btnBonus.Enabled = false;
                    break;
            }
           
        }


        private void btnPassa_Click(object sender, EventArgs e)
        {
            trnUtente--;
            if (trnUtente == 0)
            {
                if (malusUtente == true)
                {
                    if (trnUtenteMalus > 0)
                    {
                        trnUtenteMalus--;
                        trnUtente = 5;
                        
                    }
                    else
                    {
                        malusUtente = false;
                        trnUtenteMalus = 2;
                        trnUtente = 3;
                       
                    }
                }
                else
                {
                    if(utenteBonus==true)
                    {
                        if(trnUtenteBonus>0)
                        {
                            trnUtenteBonus--;
                            trnUtente = 2;
                           
                        }
                        else
                        {
                            utenteBonus = false;
                            trnUtenteBonus = 2;
                            trnUtente = 3;
                           
                        }
                    }
                    else
                    {
                        trnUtente = 3;
                    }
                }
                qtaRiservaUtente += 50000;
                txtTruppeDisponibili.Text = qtaRiservaUtente.ToString();
                ptnAzioni++;
                cmbUtente--;
                discUtente--;
                controlloOpzioni(cmbUtente, discUtente);
            }
            gestioneBottoni(false);
            rndsceltaIniz = new Random();
            int rnd=rndsceltaIniz.Next(1, 4);
            if(discBot<2&&cmbBot<2&&ptnAzioneBot>=2)
            {
                if (cmbBot < 3)
                {
                    cmbBot += 1;
                }
                if (discBot < 3)
                {
                    discUtente += 1;
                }
                ptnAzioneBot = ptnAzioneBot - 2;
            }
            switch (rnd) //azione
            {
                case 1: //spostamento
                    if (qtaRiservaBot > 10000)
                    {
                        if (fNord < 50000)
                        {
                            fNord += rndQtaTruppe.Next(10000, qtaRiservaBot / 2);
                            lstMessaggi.Items.Add("Il nemico ha spostato delle truppe al fronte Nord");
                            playSuono();
                        }
                        else
                        {
                            if (fSud < 50000)
                            {
                                fSud += rndQtaTruppe.Next(10000, qtaRiservaBot / 2);
                                lstMessaggi.Items.Add("Il nemico ha spostato delle truppe al fronte Sud");
                                playSuono();
                            }
                            else
                            {
                                fCentro += rndQtaTruppe.Next(10000, qtaRiservaBot / 2);
                                lstMessaggi.Items.Add("Il nemico ha spostato delle truppe al fronte Centrale");
                                playSuono();
                            }
                        }
                    }
                    else
                    {
                        goto case 2;
                    }
                   break;
                case 2: //assalto
                    int qta = 0;
                    int f = rndfronte.Next(1, 4);
                    if (fNord > 100000 || fSud > 100000 || fCentro > 100000)
                    {
                        if (f == 1)
                        {
                            if (fNord > 100000)
                            {
                                qta = rndQtaTruppe.Next(50000, fNord / 2);
                            }

                        }
                        else
                        {
                            if (f == 2)
                            {
                                if (fCentro > 100000)
                                {
                                    qta = rndQtaTruppe.Next(50000, fCentro / 2);
                                }
                            }
                            else
                            {
                                if (fSud > 100000)
                                {
                                    qta = rndQtaTruppe.Next(50000, fSud / 2);
                                }
                            }
                        }
                        assaltoBot(f, qta);
                        vincitaBot(f);
                    }
                    else
                        goto case 3;
                    break;
                case 3: //azioni
                    if (ptnAzioneBot >= 3)
                    {
                        ptnAzioneBot = ptnAzioneBot - 3;
                        trnUtente = trnUtente + 2;
                        trnUtenteMalus = 2;
                        malusUtente = true;
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
                                ptnAzioneBot = ptnAzioneBot - 2;
                        }

                    }
                    break;
                default:
                    break;
            }
            trnBot--;
            if(trnBot==0)
            {
                if(malusBot==true)
                {
                    if(trnBotMalus>0)
                    {
                        trnBotMalus--;
                        trnBot = 5;
                    }
                    else
                    {
                        malusBot = false;
                        trnBotMalus = 2;
                        trnBot = 3;
                        
                    }
                }
                else
                {
                    trnBot = 3;
                }
                qtaRiservaBot += 50000;
                ptnAzioneBot++;
                discBot--;
                cmbBot--;
            }
            gestioneBottoni(true);
            gestioneGiorno();
        }

        private void controlloOpzioni(int cmbUtente, int discUtente)
        {
            switch (cmbUtente)
            {
                case 3:
                    txtComb.Text = "Alta";
                    break;
                case 2:
                    txtComb.Text = "Nella media";
                    break;
                case 1:
                    txtComb.Text = "Bassa";
                    break;
                default:
                    break;
            }
            switch (discUtente)
            {
                case 3:
                    txtDisc.Text = "Alta";
                    break;
                case 2:
                    txtDisc.Text = "Nella media";
                    break;
                case 1:
                    txtDisc.Text = "Bassa";
                    break;
                default:
                    break;
            }
        }

        private void vincitaBot(int fronte)
        {
            switch (fronte)
            {
                case 1:
                    if (Convert.ToInt32(txtF1.Text) <= 0)
                    {
                        frmLost lost = new frmLost(lblAnno.Text);
                        lost.ShowDialog();
                        this.Close();
                    }
                    break;
                case 2:
                    if (Convert.ToInt32(txtF2.Text) <= 0)
                    {
                        frmLost lost = new frmLost(lblAnno.Text);
                        lost.ShowDialog();
                        this.Close();
                    }
                    break;
                case 3:
                    if (Convert.ToInt32(txtF3.Text) <= 0)
                    {
                        frmLost lost = new frmLost(lblAnno.Text);
                        lost.ShowDialog();
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        public void gestioneGiorno()
        {
            int giorno=Convert.ToInt32(lblGiorno.Text);
            int mese = Convert.ToInt32(lblMese.Text);
            int anno = Convert.ToInt32(lblAnno.Text);
            if(mese==1||mese==3|| mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12)
            {
                if(giorno==31)
                {
                    giorno = 1;
                    if(mese!=12)
                    {
                       mese++;
                    }
                    else
                    {
                        mese = 1;
                        anno++;
                    }
                   
                }
                else
                {
                   giorno++;
                }
            }
            else
            {
                if(mese!=2)
                {
                    if (giorno == 30)
                    {
                        giorno = 1;
                        mese++;
                    }
                    else
                    {
                        giorno++;
                    }
                }
                else
                {
                    if (giorno == 28)
                    {
                        giorno = 1;
                        mese++;
                    }
                    else
                    {
                        giorno++;
                    }
                }
            }
            lblGiorno.Text = giorno.ToString();
            if(mese<10)
            {
                lblMese.Text ="0"+mese.ToString();
            }
            else
            {
                lblMese.Text = mese.ToString();
            }
            lblAnno.Text = anno.ToString();
        }

        private void gestioneBottoni(bool enable)
        {
            btnAssalta.Enabled = enable;
            btnAzioni.Enabled = enable;
            btnBonus.Enabled = enable;
            btnSposta.Enabled = enable;
        }

        private void assaltoBot(int f, int qtaBot)
        {
            int totBot = qtaBot * discBot * cmbBot;
            int totUser = 0;
            int diff;
            switch (f)
            {
                case 1:
                    totUser = Convert.ToInt32(txtF1.Text) * discBot * cmbUtente;
                    break;
                case 2:
                    totUser = Convert.ToInt32(txtF2.Text) * discBot * cmbUtente;
                    break;
                case 3:
                    totUser = Convert.ToInt32(txtF3.Text) * discBot * cmbUtente;
                    break;
                default:
                    break;
            }
            diff = totBot - totUser;
           if(diff>=200000)
           {
                qtaBot = qtaBot - 200000;
                switch (f)
                {
                    case 1:
                        txtF1.Text = (Convert.ToInt32(txtF1.Text) - diff).ToString();
                        fNord = fNord - 200000;
                        break;
                    case 2:
                        txtF2.Text = (Convert.ToInt32(txtF2.Text) - diff).ToString();
                        fCentro = fCentro - 200000;
                        break;
                    case 3:
                        txtF3.Text = (Convert.ToInt32(txtF3.Text) - diff).ToString();
                        fSud = fSud - 200000;
                        break;
                    default:
                        break;
                }
                lstMessaggi.Items.Add("Il nemico ci ha attaccato e abbiamo subito 200.000 perdite");
                playSuono();
                gestioneBottoni(false);

            }
           else
            {
                if(diff>=100000)
                {
                    qtaBot = qtaBot - 100000;
                    switch (f)
                    {
                        case 1:
                            txtF1.Text = (Convert.ToInt32(txtF1.Text) - 100000).ToString();
                            fNord = fNord - 200000;
                            break;
                        case 2:
                            txtF2.Text = (Convert.ToInt32(txtF2.Text) - 100000).ToString();
                            fCentro = fCentro - 200000;
                            break;
                        case 3:
                            txtF3.Text = (Convert.ToInt32(txtF3.Text) - 100000).ToString();
                            fCentro = fCentro - 200000;
                            break;
                        default:
                            break;
                    }
                    lstMessaggi.Items.Add("Il nemico ci ha attaccato e abbiamo subito 100.000 perdite");
                    playSuono();
                    gestioneBottoni(false);
                }
                else
                {
                    qtaBot = qtaBot - 100000;
                    switch (f)
                    {
                        case 1:
                            txtF1.Text = (Convert.ToInt32(txtF1.Text) - 50000).ToString();
                            fNord = fNord - 100000;
                            break;
                        case 2:
                            txtF2.Text = (Convert.ToInt32(txtF2.Text) - 50000).ToString();
                            fSud = fSud - 100000;
                            break;
                        case 3:
                            txtF3.Text = (Convert.ToInt32(txtF3.Text) - 50000).ToString();
                            fCentro = fCentro - 100000;
                            break;
                        default:
                            break;
                    }
                    lstMessaggi.Items.Add("Il nemico ci ha attaccato e abbiamo subito 50.000 perdite");
                    playSuono();
                    gestioneBottoni(false);
                }
            }

        }

        private void btnAssalta_Click(object sender, EventArgs e)
        {
            switch (cmbFronte.SelectedItem.ToString())
            {
                case "Nord":
                    assalto("f1", Convert.ToInt32(txtF1.Text));
                    vincita("f1");
                    break;
                case "Centro":
                    assalto("f2", Convert.ToInt32(txtF2.Text));
                    vincita("f2");
                    break;
                case "Sud":
                    assalto("f3", Convert.ToInt32(txtF3.Text));
                    vincita("f3");
                    break;
                default:
                    MessageBox.Show("Selezionare fronte: nord - centro - sud");
                    break;
            }
            gestioneBottoni(false);
        }

        private void vincita(string fronte)
        {
            switch (fronte)
            {
                case "f1":
                    if(fNord<=0)
                    {
                        victory f = new victory(lblAnno.Text);
                        f.ShowDialog();
                        this.Close();
                    }
                    break;
                case "f2":
                    if (fCentro <= 0)
                    {
                        victory f = new victory(lblAnno.Text);
                        f.ShowDialog();
                        this.Close();
                    }
                    break;
                case "f3":
                    if (fSud <= 0)
                    {
                        victory f = new victory(lblAnno.Text);
                        f.ShowDialog();
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void assalto(string fronte, int qta)
        {
            int totUser = qta * discUtente * cmbUtente;
            int totBot = 0;
            int diff;
            switch (fronte)
            {
                case "f1":
                    totBot = fNord * discBot * cmbBot;
                    break;
                case "f2":
                    totBot = fCentro * discBot * cmbBot;
                    break;
                case "f3":
                    totBot = fSud * discBot * cmbBot;
                    break;
                default:
                    break;
            }
            diff = totBot - totUser;
            if (diff >= 200000)
            {
                qta = qta - 200000;
                switch (fronte)
                {
                    case "f1":
                        txtF1.Text = qta.ToString();
                        fNord = fNord - 200000;
                        break;
                    case "f2":
                        txtF2.Text = qta.ToString();
                        fCentro = fCentro - 200000;
                        break;
                    case "f3":
                        txtF3.Text = qta.ToString();
                        fSud = fSud - 200000;
                        break;
                    default:
                        break;
                }
                lstMessaggi.Items.Add("assalto eseguito con 200.000 perdite");
                playSuono();
            }
            else
            {
                if (diff >= 100000)
                {
                    qta = qta - 100000;
                    switch (fronte)
                    {
                        case "f1":
                            txtF1.Text = qta.ToString();
                            fNord = fNord - 100000;
                            break;
                        case "f2":
                            txtF2.Text = qta.ToString();
                            fCentro = fCentro - 100000;
                            break;
                        case "f3":
                            txtF3.Text = qta.ToString();
                            fSud = fSud - 100000;
                            break;
                        default:
                            break;
                    }
                    lstMessaggi.Items.Add("assalto eseguito con 100.000 perdite");
                    playSuono();
                }
                else
                {
                    qta = qta - 100000;
                    switch (fronte)
                    {
                        case "f1":
                            txtF1.Text =qta.ToString();
                            fNord = fNord - 50000;
                            break;
                        case "f2":
                            txtF2.Text = qta.ToString();
                            fCentro = fCentro - 50000;
                            break;
                        case "f3":
                            txtF3.Text = qta.ToString();
                            fSud = fSud - 50000;
                            break;
                        default:
                            break;
                    }
                    lstMessaggi.Items.Add("assalto eseguito con 100.000 perdite");
                    playSuono();
                }
            }
        }

        private void playSuono()
        {
            if (messageSound == 1)
            {
                morse.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLost lost = new frmLost(lblAnno.Text);
            lost.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            victory v = new victory(lblAnno.Text);
            v.ShowDialog();
        }
    }
}
