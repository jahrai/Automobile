using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automobile
{
    public partial class FrmAutomibilecost : Form
    {
        public FrmAutomibilecost()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submitExspenses(object sender, EventArgs e)
        {
            /*Get User Information From Text Input */
            String CarNoteStr = IntxtCarNote.Text;
            String CarInsuranceStr = inTxtCarInsurance.Text;
            String gasStr= InTxtGas.Text;
            String OilChangeStr= inTxtOilChange.Text;
            String BasicRepairStr= inTxtBasicRepairs.Text;
            String RegristrationFeesStr= inTxtRegistrationFees.Text;

            Double CarNoteDbl = Convert.ToDouble(CarNoteStr);
            Double CarInsuranceDbl = Convert.ToDouble(CarInsuranceStr);
            Double gasDbl = Convert.ToDouble(gasStr);
            Double OilChangeDbl = Convert.ToDouble(OilChangeStr);
            Double BasicRepairDbl = Convert.ToDouble(BasicRepairStr);
            Double RegristrationFeesDbl = Convert.ToDouble(RegristrationFeesStr);

            Double monthlyExspenses = CarNoteDbl + CarInsuranceDbl + gasDbl + OilChangeDbl + RegristrationFeesDbl;
            Double yearlyExpesse = monthlyExspenses * 12;

            outTxtResults.Text = "";
            
                
            outTxtResults.Text = "***Final Results***" + Environment.NewLine;
            outTxtResults.AppendText("Total Monthly Cost: " + monthlyExspenses.ToString ("c") + Environment.NewLine);
            outTxtResults.AppendText("Total yearly Cost: " + yearlyExpesse.ToString("c") + Environment.NewLine);



















        }
    }
}
