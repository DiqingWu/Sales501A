using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _501sales
{
    public partial class ControlCenter : Form
    {
        public ControlCenter()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterRebate enterRebate = new EnterRebate();
            if (enterRebate.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                
            }
            else
            {
                MessageBox.Show( "Rebates Added into DataBase, now you can print or sent by email.");
                uxGenerate.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTransaction newTransaction = new CreateTransaction();
            if (newTransaction.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.

            }
            else
            {
                MessageBox.Show("");
                
            }
        }
    }
}
