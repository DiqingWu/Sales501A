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
    public partial class CreateTransaction : Form
    {
        public CreateTransaction()
        {
            InitializeComponent();

            uxDate.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString(); //DateTime.Now.ToString("m:d:yy");//("h:mm:ss tt");//display time function
        }

        private void uxAddTrans_Click(object sender, EventArgs e)
        {
            try
            {
                string[] items = uxItems.Lines;
                string[] temp = uxCost.Lines;
                int[] costs = new int[temp.Length];                 
                for (int i = 0; i < temp.Length; i++)
                {
                    costs[i] =  Convert.ToInt32(uxCost.Lines[i]);
                }
                int id = 0;
                string dates = uxDate.Text;
                string[] tempDate = dates.Split('/');
                DateTime date = new DateTime(Convert.ToInt32(tempDate[0]), Convert.ToInt32(tempDate[1]), Convert.ToInt32(tempDate[2]));
                TransactionDataBase.AddTransaction(uxFirstName.Text,uxSecondName.Text,items,uxAdress.Text,costs,uxEmail.Text,id,date);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             
        }

        private void uxChangeDate_Click(object sender, EventArgs e)
        {
            uxDate.Enabled = true;
            uxDate.Text = "Month/Day/Year";
        }
    }
}
