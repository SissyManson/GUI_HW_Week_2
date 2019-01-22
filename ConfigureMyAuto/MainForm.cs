using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureMyAuto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radbtnFORD_CheckedChanged(object sender, EventArgs e)
        {
            pbCars.Image = ConfigureMyAuto.Properties.Resources._1969_Mustang_Mach_1_3;
            lblPrice.Text = "250000";
        }

        private void radbtnBMW_CheckedChanged(object sender, EventArgs e)
        {
            pbCars.Image = ConfigureMyAuto.Properties.Resources.bmw_m5_m5_S3543239_1;
            lblPrice.Text = "75000";
        }

        private void radbtnDODGE_CheckedChanged(object sender, EventArgs e)
        {
            pbCars.Image = ConfigureMyAuto.Properties.Resources._1970_dodge_charger_pic_43666_640x480;
            lblPrice.Text = "146300";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //cars
            radbtnBMW.Checked = false;
            radbtnDODGE.Checked = false;
            radbtnFORD.Checked = false;

            //extra adds
            chbABS.Checked = false;
            chbChains.Checked = false;
            chbFogLights.Checked = false;

            //payent
            rbCASH.Checked = false;
            rbCHEQUE.Checked = false;
            rbCREDITcard.Checked = false;

            //labels with prices
            lblDiscount.Text = "";
            LblTotalPrice.Text = "Total Price:";
            lblPrice.Text = " ";

            //picturebox
            pbCars.Image = ConfigureMyAuto.Properties.Resources.question_mark_460868_960_720;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblDiscount.Text = "0";
            int extraAdds = 0;

            //for the discount lbl
            if ((chbABS.Checked && chbFogLights.Checked && chbChains.Checked) && rbCASH.Checked)
            {
                lblDiscount.Text = "15";
            }
            else if (chbABS.Checked && chbFogLights.Checked && chbChains.Checked)
            {
                lblDiscount.Text = "10";
            }
            else if (rbCASH.Checked)
            {
                lblDiscount.Text = "5";
            }

            //for the checkboxes

            if (chbFogLights.Checked && chbChains.Checked && chbABS.Checked) // all
            {
                extraAdds += 3500;
            }
            else if (chbChains.Checked && chbABS.Checked) //1 & 2
            {
                extraAdds += 1500;
            }
            else if (chbChains.Checked && chbFogLights.Checked) // 1 & 3
            {
                extraAdds += 3000;
            }
            else if (chbABS.Checked && chbFogLights.Checked) // 2 & 3
            {
                extraAdds += 2500;
            }
            else if (chbABS.Checked)
            {
                extraAdds += 500;
            }
            else if (chbFogLights.Checked)
            {
                extraAdds += 2000;
            }
            else
            {
                extraAdds += 100;
            }


            if (lblPrice.Text != "" && lblDiscount.Text != "")
            {
                int carPrice = int.Parse(lblPrice.Text);
                int carDiscount = int.Parse(lblDiscount.Text);
                if (carPrice > 0 && carDiscount > 0)
                {
                    extraAdds += carPrice;
                    LblTotalPrice.Text = "Total Price: " + ((extraAdds + carPrice)* carDiscount) / 100 + "$"; //formula za %
                }
                else
                {
                    LblTotalPrice.Text = "Total Price: " + (extraAdds + carPrice) + "$";
                }
            }
        }
    }
}
//дали мога да намаля вложените ифове