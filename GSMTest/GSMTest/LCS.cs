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
    public partial class LCS : Form
    {
        DNALogic logic = new DNALogic();
        public LCS()
        {
            InitializeComponent();
            
        }
        private void Submit_Click(object sender, EventArgs e)
        {
                Output.Text = logic.findLongestSequence(Input1.Text, Input2.Text).ToString();
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
