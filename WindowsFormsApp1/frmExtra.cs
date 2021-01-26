using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmExtra : Form
    {
        public frmExtra()
        {
            InitializeComponent();
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            ricerca("barbero");
          
        }
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ricerca("play");
        }
        private void btnWeb_Click(object sender, EventArgs e)
        {
            ricerca("web");
        }
        private void ricerca(string pag)
        {
            switch (pag)
            {
                case "barbero":
                    Process.Start("https://www.youtube.com/watch?v=D52OqLpm7Nk");
                    break;
                case "play":
                    Process.Start("https://www.youtube.com/playlist?list=PLOok6i6xp8oF5K9jakDxxBkZukq9R27d9");
                    break;
                case "web":
                     Process.Start("http://andreabarberis.altervista.org/");
                    break;
                default:
                    break;
            }
        }

      
    }
}
