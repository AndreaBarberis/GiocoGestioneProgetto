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

namespace WindowsFormsApp1
{
    public partial class frmSelezionePersonaggio : Form
    {
        SoundPlayer italia = new SoundPlayer(@"italia.wav");
        SoundPlayer germania = new SoundPlayer(@"germania.wav");
        SoundPlayer inghilterra = new SoundPlayer(@"inghilterra.wav");
        SoundPlayer russia = new SoundPlayer(@"russia.wav");
        SoundPlayer austria = new SoundPlayer(@"austriaUngheria.wav");
        public frmSelezionePersonaggio()
        {
            InitializeComponent();
        }

        private void brnRe_Click(object sender, EventArgs e)
        {
            frmCampoGioco f = new frmCampoGioco("truppe");
            f.ShowDialog();
        }

        private void bntKing_Click(object sender, EventArgs e)
        {
            frmCampoGioco f = new frmCampoGioco("rif");
            f.ShowDialog();
        }

        private void btnZar_Click(object sender, EventArgs e)
        {
            frmCampoGioco f = new frmCampoGioco("iniz");
            f.ShowDialog();
        }

        private void btnKaiser_Click(object sender, EventArgs e)
        {
            frmCampoGioco f = new frmCampoGioco("comb");
            f.ShowDialog();
        }

        private void btnReAp_Click(object sender, EventArgs e)
        {
            frmCampoGioco f = new frmCampoGioco("az");
            f.ShowDialog();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            playMusica("italia", true);
        }
        
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            playMusica("italia", false);
        }

        private void pbKaiser_MouseHover(object sender, EventArgs e)
        {
            playMusica("germania", true);
        }

        private void pbKaiser_MouseLeave(object sender, EventArgs e)
        {
            playMusica("germania", false);
        }

        private void pbKing_MouseHover(object sender, EventArgs e)
        {
            playMusica("inghilterra", true);
        }

        private void pbKing_MouseLeave(object sender, EventArgs e)
        {
            playMusica("inghilterra", false);
        }

        private void pbZar_MouseHover(object sender, EventArgs e)
        {
            playMusica("russia", true);
        }

        private void pbZar_MouseLeave(object sender, EventArgs e)
        {
            playMusica("russia", false);
        }

        private void pbReAp_MouseHover(object sender, EventArgs e)
        {
            playMusica("austria", true);
        }

        private void pbReAp_MouseLeave(object sender, EventArgs e)
        {
            playMusica("austria", false);
        }
        private void playMusica(string song, bool status)
        {
            if (status == true)
            {
                switch (song)
                {
                    case "italia":
                        italia.Play();
                        break;
                    case "germania":
                        germania.Play();
                        break;
                    case "inghilterra":
                        inghilterra.Play();
                        break;
                    case "russia":
                        russia.Play();
                        break;
                    case "austria":
                        austria.Play();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (song)
                {
                    case "italia":
                        italia.Stop();
                        break;
                    case "germania":
                        germania.Stop();
                        break;
                    case "inghilterra":
                        inghilterra.Stop();
                        break;
                    case "russia":
                        russia.Stop();
                        break;
                    case "austria":
                        austria.Stop();
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            frmExtra f = new frmExtra();
            f.ShowDialog();
        }

        private void frmSelezionePersonaggio_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("istruzioni.pdf");

        }
    }
}
