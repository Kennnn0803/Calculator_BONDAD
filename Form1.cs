using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_BONDAD
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool opperformed = false;
        String first, second;
        bool equal = false;


        public Form1()
        {
            InitializeComponent();
            memorybox.Visible = false;
        }

        private void button_click(object sender, EventArgs e)
        {
            
            

            if ((tbox.Text == "0") || (opperformed) ) 
                tbox.Clear();
            opperformed = false;

            Button button = (Button)sender;

            // ililimit yung dot to once lang pede ma click pag na click na para avoided ang error
            if (button.Text == ".")

            {
                if (!tbox.Text.Contains("."))

                    tbox.Text = tbox.Text + button.Text;
                

            }else
            
                tbox.Text = tbox.Text + button.Text;   
                
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            // kapag continuous yung pag input ng numbers at operation, gagawin niya agad before mag click ng new operator


            if (equal == false)
            {
                bequal.PerformClick();
                equal = false;
                operation = button.Text;
                result = Double.Parse(tbox.Text);
                labelCO.Text = "History: " + result + " " + operation;
                opperformed = true;
                
            }
            else
            {
                    operation = button.Text;
                    result = Double.Parse(tbox.Text);
                    labelCO.Text = "History: " + result + " " + operation;
                    opperformed = true;
                    
            }

                       
            first = labelCO.Text;
        }

        
        private void ce_click(object sender, EventArgs e)
        {
            operation = "";
            equal = false;
            opperformed = false;
            tbox.Text = "0";
            result = 0;
            labelCO.Text = "Clear Entry!";
        }

        private void c_click(object sender, EventArgs e)
        {
            operation = "";
            equal = false;
            opperformed = false;
            tbox.Text = "0";
            result = 0;
            labelCO.Text = "Clear!";
            memorybox.Clear();
            if (memorybox.Text == "")
            {
                memorybox.Text = "Memory Cleared";
            }
        }

        private void equal_click(object sender, EventArgs e)
        {
            equal = true;
            second = tbox.Text;
            // nag switch ako para under ng switch, yung cases na nakapaloob ay yung lahat ng operations na meron sa calcu ko
            switch (operation)
            {
                case "+":
                    tbox.Text = (result + Double.Parse(tbox.Text)).ToString();
                    break;
                case "-":
                    tbox.Text = (result - Double.Parse(tbox.Text)).ToString();
                    break;
                case "/":
                    tbox.Text = (result / Double.Parse(tbox.Text)).ToString();
                    break;
                case "*":
                    tbox.Text = (result * Double.Parse(tbox.Text)).ToString();
                    break;
                case "√":
                    tbox.Text = (Math.Sqrt(Double.Parse(tbox.Text))).ToString();
                    break;
                case "sqr":
                    tbox.Text = (Math.Pow(Double.Parse(tbox.Text), 2)).ToString();
                    break;
                case "cub":
                    tbox.Text = (Math.Pow(Double.Parse(tbox.Text), 3)).ToString();
                    break;
                case "Mod":
                    tbox.Text = (result % Double.Parse(tbox.Text)).ToString();
                    break;

                default:
                    break;


            }


            
            memorybox.AppendText("\n" + first + "  " + second + "  = " + "\n");
            memorybox.AppendText("\n" + tbox.Text + "\n\n");
            labelCO.Text = " ";


        }

        private void bmemory_Click(object sender, EventArgs e)
        {
            
        
            memorybox.Visible = true;

        }

        private void bcmemory_Click(object sender, EventArgs e)
        {
            memorybox.Clear();
            if (memorybox.Text == "")
            {
                memorybox.Text = "Memory Cleared";
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            if (Double.Parse(tbox.Text) > 0)
            {
                tbox.Text = tbox.Text.Remove(tbox.Text.Length - 1, 1);
            }
            if (tbox.Text == "")
            {
                tbox.Text = "0";
            }
            
        }

    }
}
