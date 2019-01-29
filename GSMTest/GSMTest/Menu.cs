using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMTest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void ASCII_to_DNA_Clicked(object sender, EventArgs e)
        {
            ASCIIToDNA form = new ASCIIToDNA();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void DNA_to_ASCII_Clicked(object sender, EventArgs e)
        {
            DNAToASCII form = new DNAToASCII();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
        private void LCS_Click(object sender, EventArgs e)
        {
            LCS lcs = new LCS();
            lcs.Tag = this;
            lcs.Show(this);
            Hide();
        }
    }
}
