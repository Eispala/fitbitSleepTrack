using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBitSleeptrack
{
    public partial class frmPopUp : Form
    {
        public frmPopUp()
        {
            InitializeComponent();
        }

        public string pastedURL;

        private void frmPopUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pastedURL = textBox1.Text;
        }
    }
}
