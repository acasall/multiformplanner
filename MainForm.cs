using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiformplanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            double yearlyInvestment, growthRate, investmentGoal;

            double.TryParse(txtInvestment.Text, out yearlyInvestment);
            double.TryParse(txtRate.Text, out growthRate);
            double.TryParse(txtGoal.Text, out investmentGoal);
            
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();

            displayForm.lstDisplay.Items.Add(string.Format("{0, 7}{1, 20}","Year", "Current Value"));

            int year = 1;
            double currentValue = 0;

            while(currentValue < investmentGoal)
            {
                currentValue = (currentValue + yearlyInvestment) * (1 + growthRate / 100);
                displayForm.lstDisplay.Items.Add(string.Format("{0, 7}{1, 20}", year, currentValue.ToString("C")));
                year = year + 1;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
