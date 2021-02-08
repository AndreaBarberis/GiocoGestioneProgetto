using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAzioni : Form
    {
        string az;
        int puntiAz;
        public frmAzioni()
        {
            InitializeComponent();
        }
        public frmAzioni(int punti)
        {
            InitializeComponent();
            puntiAz = punti;
           
        }
        public string azione()
        {
            return az;
        }
        public int punti()
        {
            return puntiAz;
        }
        private void btnDisc_Click(object sender, EventArgs e)
        {
            az = "disc";
            puntiAz = puntiAz-2;
            this.Close();
        }

        private void btnTre_Click(object sender, EventArgs e)
        {
            az = "treno";
            puntiAz = puntiAz-3;
            this.Close();
        }

        private void btnSpia_Click(object sender, EventArgs e)
        {
            az = "spia";
            puntiAz = puntiAz-4;
            this.Close();
        }

        private void frmAzioni_Load(object sender, EventArgs e)
        {
            switch (puntiAz)
            {
                case 2:
                    btnDisc.Enabled = true;
                    btnSpia.Enabled = false;
                    btnTre.Enabled = false;
                    break;
                case 3:
                    btnDisc.Enabled = true;
                    btnSpia.Enabled = true;
                    btnTre.Enabled = false;
                    break;
                case 4:
                    btnDisc.Enabled = true;
                    btnSpia.Enabled = true;
                    btnTre.Enabled = true;
                    break;
                default:
                    btnDisc.Enabled = false;
                    btnSpia.Enabled = false;
                    btnTre.Enabled = false;
                    break;
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            az = "";
            this.Close();
        }
    }
}
