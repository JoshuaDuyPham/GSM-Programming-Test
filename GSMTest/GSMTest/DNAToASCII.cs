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
    public partial class DNAToASCII : Form
    {
        DNALogic logic = new DNALogic();
        public DNAToASCII()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            if (typeStrand.GetItemText(this.typeStrand.SelectedItem) == "Primary Strand")
                Output.Text = logic.findStrand(Input1.Text);
            else if (typeStrand.GetItemText(this.typeStrand.SelectedItem) == "Complementary Strand")
                Output.Text = logic.findCompliment(Input1.Text);
            else
                Output.Text = "Please choose a type";
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Tag = this;
            menu.Show(this);
            Hide();
        }
    }
}
