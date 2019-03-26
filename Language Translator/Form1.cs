using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void italianBtn_Click(object sender, EventArgs e)
        {
            lblTranslationLabel.Text = "Buongiorno";
        }

        private void spanishBtn_Click(object sender, EventArgs e)
        {
            lblTranslationLabel.Text = "Buenos Dias";
        }

        private void germanBtn_Click(object sender, EventArgs e)
        {
            lblTranslationLabel.Text = "Guten Morgen";
        }
    }
}
