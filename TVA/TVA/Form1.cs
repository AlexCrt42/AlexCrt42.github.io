using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVA
{
    public partial class frmTVA : Form
    {
        public frmTVA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbx_TTC.Text == "")
            {
                double l_HT = double.Parse(tbx_HT.Text);
                double l_TVA = double.Parse(tbx_TVA.Text);
                tbx_TTC.Text = Convert.ToString(l_HT * l_TVA / 100 + l_HT);
            }
            else if (tbx_HT.Text == "")
            {
                double l_TVA = double.Parse(tbx_TVA.Text);
                double l_TTC = double.Parse(tbx_TTC.Text);
                tbx_HT.Text = Convert.ToString(l_TTC / (1 + l_TVA / 100));
            }
            else
            {
                double l_HT = double.Parse(tbx_HT.Text);
                double l_TTC = double.Parse(tbx_TTC.Text);
                tbx_TVA.Text = Convert.ToString((l_TTC - l_HT) / l_HT * 100);
            }
        }

        private void lbl_TVA_Click(object sender, EventArgs e)
        {

        }
    }
}
