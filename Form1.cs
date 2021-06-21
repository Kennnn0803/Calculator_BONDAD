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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((tbox.Text == "0") || (opperformed) ) 
                tbox.Clear();

            opperformed = false;

            Button button=(Button)sender;

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
            if (result != 0)
            {
                bequal.PerformClick();
                operation = button.Text;
                result = Double.Parse(tbox.Text);
                labelCO.Text = "History: " + result + " " + operation;
                opperformed = true;
            }
            else


            operation = button.Text;
            result = Double.Parse(tbox.Text);
            labelCO.Text = "History: " + result + " " + operation;
            opperformed = true;

        }

        private void ce_click(object sender, EventArgs e)
        {
            tbox.Text = "0";
        }

        private void c_click(object sender, EventArgs e)
        {
            tbox.Text = "0";
            result = 0;
        }

        private void equal_click(object sender, EventArgs e)
        {
            switch(operation)
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
                default:
                    break;
            }
            // mag a-appear yung done kapag clinick na yung equal sign imbis na operator
            result = Double.Parse(tbox.Text);
            labelCO.Text = "Done!";
        }
    }
}
