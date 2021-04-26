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
    public partial class victory : Form
    {
        string annoFine;
        public victory(string anno)
        {
            InitializeComponent();
            annoFine = anno;
        }

        private void victory_Load(object sender, EventArgs e)
        {
            label4.Text = label4.Text + annoFine;
        }
    }
}
