using System;
using System.Windows.Forms;

namespace Sunny_Surfboards_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // surfboards
        double sLPCost = 50;
        double sLPQty = 0;
        string sLPName = "Surfboard Lrg Pro";

        double sLBCost = 50;
        double sLBQty = 0;
        string sLBName = "Surfboard Lrg Beg";

        double sMPCost = 40;
        double sMPQty = 0;
        string sMPName = "Surfboard Med Pro";

        double sMBCost = 40;
        double sMBQty = 0;
        string sMBName = "Surfboard Med Beg";

        double sSPCost = 30;
        double sSPQty = 0;
        string sSPName = "Surfboard Sml Pro";

        double sSBCost = 30;
        double sSBQty = 0;
        string sSBName = "Surfboard Sml Beg";

        // wetsuits
        double wLBCost = 15;
        double wLBQty = 0;
        string wLBName = "Wetsuit Lrg Blue Thick";


        double wLRCost = 15;
        double wLRQty = 0;
        string wLRName = "Wetsuit Lrg Red Thin";

        double wMBCost = 10;
        double wMBQty = 0;
        string wMBName = "Wetsuit Med Blue Thick";

        double wMRCost = 10;
        double wMRQty = 0;
        string wMRName = "Wetsuit Med Red Thin";

        double wSBCost = 8;
        double wSBQty = 0;
        string wSBName = "Wetsuit Sml Blue Thick";

        double wSRCost = 8;
        double wSRQty = 0;
        string wSRName = "Wetsuit Sml Red Thin";

        string orderMessage = "";
        double fullDayTotal = 0;

        public void btnAddSLP_Click(object sender, EventArgs e)
        {
            sLPQty += 1;
            txtSLP.Text = sLPQty.ToString() + " x " + sLPName;
            txtSLPTotal.Text = (sLPQty * sLPCost).ToString();
        }

        private void btnSLPClear_Click(object sender, EventArgs e)
        {
            sLPQty = 0;
            txtSLP.Text = sLPQty.ToString() + " x " + sLPName;
            txtSLPTotal.Text = sLPQty.ToString();
        }

        private void btnMinusSLP_Click(object sender, EventArgs e)
        {
            if (sLPQty > 0)
            {
                sLPQty -= 1;
                txtSLP.Text = sLPQty.ToString() + " x " + sLPName;
                txtSLPTotal.Text = (sLPQty * sLPCost).ToString();
            }
            else
            {
                txtSLP.Text = sLPQty.ToString() + " x " + sLPName;
                txtSLPTotal.Text = sLPQty.ToString();
            }
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDFTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcFDTotal_Click(object sender, EventArgs e)
        {
            double sLPTotal = Convert.ToDouble(txtSLPTotal.Text);
            double sLBTotal = Convert.ToDouble(txtSLBTotal.Text);
            double sMPTotal = Convert.ToDouble(txtSMPTotal.Text);
            double sMBTotal = Convert.ToDouble(txtSMBTotal.Text);
            double sSPTotal = Convert.ToDouble(txtSSPTotal.Text);
            double sSBTotal = Convert.ToDouble(txtSSBTotal.Text);

            double wLBTotal = Convert.ToDouble(txtWLBTotal.Text);
            double wLRTotal = Convert.ToDouble(txtWLRTotal.Text);
            double wMBTotal = Convert.ToDouble(txtWMBTotal.Text);
            double wMRTotal = Convert.ToDouble(txtWMRTotal.Text);
            double wSBTotal = Convert.ToDouble(txtWSBTotal.Text);
            double wSRTotal = Convert.ToDouble(txtWSRTotal.Text);

            double fdTotal = sLPTotal + sLBTotal + sMPTotal + sMBTotal + sSPTotal + sSBTotal + wLBTotal + wLRTotal + wMBTotal + wMRTotal + wSBTotal + wSRTotal;
            double hDTotal = fdTotal / 2;

            txtFDTotal.Text = fdTotal.ToString();
            txtHDTotal.Text = hDTotal.ToString();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            var messageResult = MessageBox.Show("Are you sure?", "Clear All", MessageBoxButtons.YesNo);

            if (messageResult == DialogResult.Yes)
            {
                txtFDTotal.Text = "0";
                txtHDTotal.Text = "0";
                // surfboards
                sLPQty = 0;
                txtSLP.Text = sLPQty.ToString() + " x " + sLPName;
                txtSLPTotal.Text = "0";

                sLBQty = 0;
                txtSLB.Text = sLBQty.ToString() + " x " + sLBName;
                txtSLBTotal.Text = "0";

                sMPQty = 0;
                txtSMP.Text = sMPQty.ToString() + " x " + sMPName;
                txtSMPTotal.Text = "0";

                sMBQty = 0;
                txtSMB.Text = sMBQty.ToString() + " x " + sMBName;
                txtSMBTotal.Text = "0";

                sSPQty = 0;
                txtSSP.Text = sSPQty.ToString() + " x " + sSPName;
                txtSSPTotal.Text = "0";

                sSBQty = 0;
                txtSSB.Text = sSBQty.ToString() + " x " + sSBName;
                txtSSBTotal.Text = "0";
                // wetsuits
                wLBQty = 0;
                txtWLB.Text = wLBQty.ToString() + " x " + wLBName;
                txtWLBTotal.Text = "0";

                wLRQty = 0;
                txtWLR.Text = wLRQty.ToString() + " x " + wLRName;
                txtWLRTotal.Text = "0";

                wMBQty = 0;
                txtWMB.Text = wMBQty.ToString() + " x " + wMBName;
                txtWMBTotal.Text = "0";

                wMRQty = 0;
                txtWMR.Text = wMRQty.ToString() + " x " + wMRName;
                txtWMRTotal.Text = "0";

                wSBQty = 0;
                txtWSB.Text = wSBQty.ToString() + " x " + wSBName;
                txtWSBTotal.Text = "0";

                wSRQty = 0;
                txtWSR.Text = wSRQty.ToString() + " x " + wSRName;
                txtWSRTotal.Text = "0";
            }
            // ideally set all variables to 0, change "0" to variable names - but can't (local?)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSLB_Click(object sender, EventArgs e)
        {
            sLBQty += 1;
            txtSLB.Text = sLBQty.ToString() + " x " + sLBName;
            txtSLBTotal.Text = (sLBQty * sLBCost).ToString();
        }

        private void btnMinusSLB_Click(object sender, EventArgs e)
        {
            if (sLBQty > 0)
            {
                sLBQty -= 1;
                txtSLB.Text = sLBQty.ToString() + " x " + sLBName;
                txtSLBTotal.Text = (sLBQty * sLBCost).ToString();
            }
            else
            {
                txtSLB.Text = sLBQty.ToString() + " x " + sLBName;
                txtSLBTotal.Text = sLBQty.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sLBQty = 0;
            txtSLB.Text = sLBQty.ToString() + " x " + sLBName;
            txtSLBTotal.Text = sLBQty.ToString();
        }

        private void btnAddSMP_Click(object sender, EventArgs e)
        {
            sMPQty += 1;
            txtSMP.Text = sMPQty.ToString() + " x " + sMPName;
            txtSMPTotal.Text = (sMPQty * sMPCost).ToString();
        }

        private void btnMinusSMP_Click(object sender, EventArgs e)
        {
            if (sMPQty > 0)
            {
                sMPQty -= 1;
                txtSMP.Text = sMPQty.ToString() + " x " + sMPName;
                txtSMPTotal.Text = (sMPQty * sMPCost).ToString();
            }
            else
            {
                txtSMP.Text = sMPQty.ToString() + " x " + sMPName;
                txtSMPTotal.Text = sMPQty.ToString();
            }
        }

        private void btnClearSMP_Click(object sender, EventArgs e)
        {
            sMPQty = 0;
            txtSMP.Text = sMPQty.ToString() + " x " + sMPName;
            txtSMPTotal.Text = sMPQty.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sMBQty += 1;
            txtSMB.Text = sMBQty.ToString() + " x " + sMBName;
            txtSMBTotal.Text = (sMBQty * sMBCost).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (sMBQty > 0)
            {
                sMBQty -= 1;
                txtSMB.Text = sMBQty.ToString() + " x " + sMBName;
                txtSMBTotal.Text = (sMBQty * sMBCost).ToString();
            }
            else
            {
                txtSMB.Text = sMBQty.ToString() + " x " + sMBName;
                txtSMBTotal.Text = sMBQty.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sMBQty = 0;
            txtSMB.Text = sMBQty.ToString() + " x " + sMBName;
            txtSMBTotal.Text = sMBQty.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sSPQty += 1;
            txtSSP.Text = sSPQty.ToString() + " x " + sSPName;
            txtSSPTotal.Text = (sSPQty * sSPCost).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (sSPQty > 0)
            {
                sSPQty -= 1;
                txtSSP.Text = sSPQty.ToString() + " x " + sSPName;
                txtSSPTotal.Text = (sSPQty * sSPCost).ToString();
            }
            else
            {
                txtSSP.Text = sSPQty.ToString() + " x " + sSPName;
                txtSSPTotal.Text = sSPQty.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sSPQty = 0;
            txtSSP.Text = sSPQty.ToString() + " x " + sSPName;
            txtSSPTotal.Text = sSPQty.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sSBQty += 1;
            txtSSB.Text = sSBQty.ToString() + " x " + sSBName;
            txtSSBTotal.Text = (sSBQty * sSBCost).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sSBQty > 0)
            {
                sSBQty -= 1;
                txtSSB.Text = sSBQty.ToString() + " x " + sSBName;
                txtSSBTotal.Text = (sSBQty * sSBCost).ToString();
            }
            else
            {
                txtSSB.Text = sSBQty.ToString() + " x " + sSBName;
                txtSSBTotal.Text = sSBQty.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sSBQty = 0;
            txtSSB.Text = sSBQty.ToString() + " x " + sSBName;
            txtSSBTotal.Text = sSBQty.ToString();
        }

        private void btnAddWLB_Click(object sender, EventArgs e)
        {
            wLBQty += 1;
            txtWLB.Text = wLBQty.ToString() + " x " + wLBName;
            txtWLBTotal.Text = (wLBQty * wLBCost).ToString();
        }

        private void btnMinusWLB_Click(object sender, EventArgs e)
        {
            if (wLBQty > 0)
            {
                wLBQty -= 1;
                txtWLB.Text = wLBQty.ToString() + " x " + wLBName;
                txtWLBTotal.Text = (wLBQty * wLBCost).ToString();
            }
            else
            {
                txtWLB.Text = wLBQty.ToString() + " x " + wLBName;
                txtWLBTotal.Text = wLBQty.ToString();
            }
        }

        private void btnClearWLB_Click(object sender, EventArgs e)
        {
            wLBQty = 0;
            txtWLB.Text = wLBQty.ToString() + " x " + wLBName;
            txtWLBTotal.Text = wLBQty.ToString();
        }

        private void btnAddWLR_Click(object sender, EventArgs e)
        {
            wLRQty += 1;
            txtWLR.Text = wLRQty.ToString() + " x " + wLRName;
            txtWLRTotal.Text = (wLRQty * wLRCost).ToString();
        }

        private void btnAddWMB_Click(object sender, EventArgs e)
        {
            wMBQty += 1;
            txtWMB.Text = wMBQty.ToString() + " x " + wMBName;
            txtWMBTotal.Text = (wMBQty * wMBCost).ToString();
        }

        private void btnAddWMR_Click(object sender, EventArgs e)
        {
            wMRQty += 1;
            txtWMR.Text = wMRQty.ToString() + " x " + wMRName;
            txtWMRTotal.Text = (wMRQty * wMRCost).ToString();
        }

        private void btnAddWSB_Click(object sender, EventArgs e)
        {
            wSBQty += 1;
            txtWSB.Text = wSBQty.ToString() + " x " + wSBName;
            txtWSBTotal.Text = (wSBQty * wSBCost).ToString();
        }

        private void btnAddWSR_Click(object sender, EventArgs e)
        {
            wSRQty += 1;
            txtWSR.Text = wSRQty.ToString() + " x " + wSRName;
            txtWSRTotal.Text = (wSRQty * wSRCost).ToString();
        }

        private void btnMinusWLR_Click(object sender, EventArgs e)
        {
            if (wLRQty > 0)
            {
                wLRQty -= 1;
                txtWLR.Text = wLRQty.ToString() + " x " + wLRName;
                txtWLRTotal.Text = (wLRQty * wLRCost).ToString();
            }
            else
            {
                txtWLR.Text = wLRQty.ToString() + " x " + wLRName;
                txtWLRTotal.Text = wLRQty.ToString();
            }
        }

        private void btnMinusWMB_Click(object sender, EventArgs e)
        {
            if (wMBQty > 0)
            {
                wMBQty -= 1;
                txtWMB.Text = wMBQty.ToString() + " x " + wMBName;
                txtWMBTotal.Text = (wMBQty * wMBCost).ToString();
            }
            else
            {
                txtWMB.Text = wMBQty.ToString() + " x " + wMBName;
                txtWMBTotal.Text = wMBQty.ToString();
            }
        }

        private void btnMinusWMR_Click(object sender, EventArgs e)
        {
            if (wMRQty > 0)
            {
                wMRQty -= 1;
                txtWMR.Text = wMRQty.ToString() + " x " + wMRName;
                txtWMRTotal.Text = (wMRQty * wMRCost).ToString();
            }
            else
            {
                txtWMR.Text = wMRQty.ToString() + " x " + wMRName;
                txtWMRTotal.Text = wMRQty.ToString();
            }
        }

        private void btnMinusWSB_Click(object sender, EventArgs e)
        {
            if (wSBQty > 0)
            {
                wSBQty -= 1;
                txtWSB.Text = wSBQty.ToString() + " x " + wSBName;
                txtWSBTotal.Text = (wSBQty * wSBCost).ToString();
            }
            else
            {
                txtWSB.Text = wSBQty.ToString() + " x " + wSBName;
                txtWSBTotal.Text = wSBQty.ToString();
            }
        }

        private void btnMinusWSR_Click(object sender, EventArgs e)
        {
            if (wSRQty > 0)
            {
                wSRQty -= 1;
                txtWSR.Text = wSRQty.ToString() + " x " + wSRName;
                txtWSRTotal.Text = (wSRQty * wSRCost).ToString();
            }
            else
            {
                txtWSR.Text = wSRQty.ToString() + " x " + wSRName;
                txtWSRTotal.Text = wSRQty.ToString();
            }
        }

        private void btnClearWLR_Click(object sender, EventArgs e)
        {
            wLRQty = 0;
            txtWLR.Text = wLRQty.ToString() + " x " + wLRName;
            txtWLRTotal.Text = wLRQty.ToString();
        }

        private void btnClearWMB_Click(object sender, EventArgs e)
        {
            wMBQty = 0;
            txtWMB.Text = wMBQty.ToString() + " x " + wMBName;
            txtWMBTotal.Text = wMBQty.ToString();
        }

        private void btnClearWSB_Click(object sender, EventArgs e)
        {
            wSBQty = 0;
            txtWSB.Text = wSBQty.ToString() + " x " + wSBName;
            txtWSBTotal.Text = wSBQty.ToString();
        }

        private void btnClearWMR_Click(object sender, EventArgs e)
        {
            wMRQty = 0;
            txtWMR.Text = wMRQty.ToString() + " x " + wMRName;
            txtWMRTotal.Text = wMRQty.ToString();
        }

        private void btnClearWSR_Click(object sender, EventArgs e)
        {
            wSRQty = 0;
            txtWSR.Text = wSRQty.ToString() + " x " + wSRName;
            txtWSRTotal.Text = wSRQty.ToString();
        }
    }
}
