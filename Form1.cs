using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ian_McIntosh___Week3Ex8
{
    public partial class pictureBoxDisplay : Form
    {
        public pictureBoxDisplay()
        {
            InitializeComponent();
        }

        private void buttonCalCosts_Click(object sender, EventArgs e)
        {
            // -- Pseudo code -- 
            // C - Declare variables 
            int numTickets = 0;
            double discRate = 0;
            decimal totalCost = 0;
            decimal discAmount = 0;
            decimal finalCost = 0;

            // E - Get the number of tickets (textBoxNumTickets)
            numTickets = int.Parse((string)textBoxNumTickets.Text);

            // H - Get the discount rate (textBoxDiscRate)
            discRate = double.Parse(textBoxDiscRate.Text);

            // A - Calculate the total cost of tickets
            totalCost = numTickets * 20m;

            // I - Calculate the discount amount 
            // Cast: treats a value as another datatype for this calculation.
            // Cannot case numeric datatypes and strings
            discAmount = totalCost * (decimal)discRate;

            // G - Calculate the final cost (textBox)
            finalCost = totalCost - discAmount;


            // B - Display the cost of tickets without discount (textBox)
            textBoxCostOfTickets.Text = totalCost.ToString("c");


            // F - Display the discount amount (textBox)
            textBoxDiscAmount.Text = discAmount.ToString("c");


            // D - Display the final cost (textBox)
            textBoxFinalCost.Text = finalCost.ToString("c");

        }

        // -- Ex 1 --

        // DataType: The type of information to store in the computers memory
        // int - Whole Numbers (45, -10)
        // double - real numbers (45.7575, -10.34)
        // decimal - real numbers but for money values 
        // string - series of characters ("Mary") 
        // bool - stores the value true or false. 

        // -- Ex 2 -- 

        // Variable: A memory location used to store a value and the value can be changed while the application is running. 
        // datatype name = inital_value;
        // int hourWorked = 0; 
        // string name ""; 
        // bool valid = false; 

        // -- Ex 3 -- 

        // string title = "";
        // int year = 0;
        // decimal rentalPrice = 0;
        // bool hired = false; 

        // -- Ex 4 -- 

        // title = Serenity;
        // year = 2005;
        // rentalPrice = 3.5m
        // hired = true;

        //string title = "";
        //int year = 0;
        //decimal rentalPrice = 0;
        //bool hired = false;

        //title = "Serenity";
        //year = 2005;
        //rentalPrice = 3.5m;
        //hired = true;
    }
}
