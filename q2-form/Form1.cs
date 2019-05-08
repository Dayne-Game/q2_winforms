using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q2_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PersonBtn_Click(object sender, EventArgs e)
        {
            PersonWindow pw = new PersonWindow();
            pw.Show();
        }

        private void SupervisorBtn_Click(object sender, EventArgs e)
        {
            SupervisorWindow sw = new SupervisorWindow();
            sw.Show();
        }
    }
}
