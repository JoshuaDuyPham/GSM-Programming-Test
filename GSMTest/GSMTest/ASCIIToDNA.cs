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
    public partial class ASCIIToDNA : Form
    {
        DNALogic logic = new DNALogic();
        public ASCIIToDNA()
        {
            InitializeComponent();
        }
        //When the submit button is clicked 
        private void Submit_Click(object sender, EventArgs e)
        {
            if (TypeStrand.GetItemText(this.TypeStrand.SelectedItem) == "DNA")
                Output.Text = logic.toDNA(Input1.Text);
            else if(TypeStrand.GetItemText(this.TypeStrand.SelectedItem) == "RNA")        
                Output.Text = logic.toRNA(Input1.Text);
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
