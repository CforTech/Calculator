using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        
        public Form1()
        {
            InitializeComponent();
        }


        public void disable()
        {
            textBox_Result.Enabled = false;

            button19.Show();
            button9.Hide();
            button1.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;     
        }


        public void enable()    // create one function to on the calculator
        {



        }
        
        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text =="0") || (isOperationPerformed))
                textBox_Result.Clear();


            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                
                if(!textBox_Result.Text.Contains("."))
               textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
            textBox_Result.ForeColor = Color.Red;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button14.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
                label1CurrentOperation.Text = resultValue + "" + operationPerformed;
            }
            
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
            label1CurrentOperation.Text = resultValue + "" + operationPerformed;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                  break;
                
                case "-":
                  textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                  break;
                case "*":
                  textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                  break;
                case "/":
                  textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                  break;
                default:
                  
                    break;

            }


            resultValue = Double.Parse(textBox_Result.Text);
            label1CurrentOperation.Text = "";
        
        
        }



        private void button9_Click(object sender, EventArgs e)
        {
            disable(); // calculator enable () function to on
        }
    
        
        private void button19_Click(object sender, EventArgs e)  // off button
             
        {
            enable(); // disable fuction () off calculator
        }

      
    
    
    }
   
}

