using System;
using System.IO;
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
    public partial class EnterRebate : Form
    {
        public EnterRebate()
        {
            InitializeComponent();
            uxRebateText.AppendText( "If add rebate manually "+ Environment.NewLine+ "Enter format(month/date/year,item name,save percent)" + Environment.NewLine + "if all items rebate enter (ALL) " + Environment.NewLine + "Examples:" + Environment.NewLine + "2/13/2018,AppleWatch,25"+Environment.NewLine+"2/14/2018,ALL,11");
            //uxRebateText.Lines =
        }
        /// <summary>
        /// not valid method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// unnassary method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRebateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxAddByFile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// button for manually enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddManually_Click(object sender, EventArgs e)
        {
            uxAddRebate.Enabled = true;
            uxRebateText.Enabled = true;
            uxAddByFile.Enabled = false;
            uxRebateText.Text = "";
        }

        private void uxAddRebate_Click(object sender, EventArgs e)
        {
            addStringToDataBase();
        }


        private void addStringToDataBase()
        {
            try
            {
                /****************************************************/
                //get string by line. and
                StringReader sr = new StringReader(uxRebateText.Text);
                string lineA = null;
                string[] lineB = null; // save 3 value by split line A;
                string[] lineC = null; // save value date in this C;
                int count = 0;
                lineA = sr.ReadLine();
                while (lineA != null)
                {

                    lineB = lineA.Split(',');
                    // split each line 
                    lineC = lineB[0].Split('/');
                    // split time by month/date/year
                    RebatesDataBase.AddRebates(new DateTime(Convert.ToInt32(lineC[2]), Convert.ToInt32(lineC[0]), Convert.ToInt32(lineC[1])), lineB[1], Convert.ToInt32(lineB[2]));
                    //implement by year month day
                    lineA = sr.ReadLine();
                    count++;

                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uxCancelRebate_Click(object sender, EventArgs e)
        {
            /*method test here: 2/1/2018,ALL,50 
            DateTime TestDay = new DateTime(2018, 1, 5);
            MessageBox.Show(RebatesDataBase.GetOff(TestDay, "sadaew").ToString());
            */
            this.Dispose();

        }
    }
}
