using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arshad_khan_Ex_01
{
    public partial class TargetGpa : Form
    {
        GpaCalcForm main = null;
        public TargetGpa(GpaCalcForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonCalcTarget_Click(object sender, EventArgs e)
        {
            try
            {
                double currentGpa = Convert.ToDouble(textBoxCurrentGpa.Text);
                double targetGpa = Convert.ToDouble(textBoxTargetGpa.Text);
                int currentCreds = Convert.ToInt32(textBoxCurrentCreds.Text);
                int futureCreds = Convert.ToInt32(textBoxFutureCreds.Text);

                double cumulatGrade = currentGpa * currentCreds;
                int totalCreds = currentCreds + futureCreds;
                double inter = targetGpa * totalCreds;

                double final = inter - cumulatGrade;
                double result2 = final / futureCreds;

                labelTargetResult.Text = "I need a GPA of: " + result2.ToString("0.###");

                this.main.SendValue(labelTargetResult.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
