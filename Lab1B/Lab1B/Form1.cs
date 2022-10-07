using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Exception for if something goes wrong, otherwise this calculates the Math for the Revenues program
            try
            {

                int classA;

                int classB;

                int classC;

                int Total;

                //Calculations per ticket type

                classA = int.Parse(txtClassA.Text) * 15;

                classB = int.Parse(txtClassB.Text) * 12;

                classC = int.Parse(txtClassC.Text) * 9;

                Total = classA + classB + classC;

                //display for ticket types

                txtRevA.Text = classA.ToString("c");
                txtRevB.Text = classB.ToString("c");
                txtRevC.Text = classC.ToString("c");
                txtTotal.Text = Total.ToString("c");
            }
            catch {
                MessageBox.Show(
                    "An error has occurred please try again",
                    "ERROR"
                    );
            }
        }
        //This is what makes the clear button clear out all values
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Text = " ";
            txtClassB.Text = " ";
            txtClassC.Text = " ";

            txtRevA.Text = " ";
            txtRevB.Text = " ";
            txtRevC.Text = " ";
            txtTotal.Text = " ";

        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //I had help on This program from a family member and Referenced a similar code for another program
       
    }
}
