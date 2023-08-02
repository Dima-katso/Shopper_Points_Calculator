using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac9._1_Shopper_Points_Calculator_37409700
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CalculateDisplayPoints(double total, int tier)
        {
            //local variable
            double points;
            
            switch (tier)
            {
                case 1:
                    //calaculate the ponits and display them
                    points = total * 0.10;
                    lblpoints.Text = points.ToString();
                    break;

                case 2:
                    points = total * 0.20;
                    lblpoints.Text = points.ToString();
                    break;
                default:
                    points = total * 0.30;
                    lblpoints.Text = points.ToString();
                    break;
            }

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //local variables
            double itotal;
            int tier;
            //data validation
            if (double.TryParse(txttotal.Text, out itotal))
            {
                //check if the radio button is checked
                if (radio1.Checked)
                {
                    tier = 1;
                }
                else if (radio2.Checked)
                {
                    tier = 2;
                }
                else
                {
                    tier = 3;
                }
                //Call the void method
                CalculateDisplayPoints(itotal, tier);


            }



        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //Clear the label and the text
            txttotal.Text = " ";
            lblpoints.Text = " ";
        }
    }
}

