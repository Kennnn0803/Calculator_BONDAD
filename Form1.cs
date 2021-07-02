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
        var variables = new var();
            

        public Form1()
        {
            InitializeComponent();
            memorybox.Visible = false;
        }

        private void button_click(object sender, EventArgs e)
        {
            
            if ((tbox.Text == "0") || (variables.opperformed) ) 
                tbox.Clear();
            variables.opperformed = false;

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


            if (variables.equal == false)
            {
                bequal.PerformClick();
                variables.equal = false;
                variables.operation = button.Text;
                variables.result = Double.Parse(tbox.Text);
                labelCO.Text = "History: " + variables.result + " " + variables.operation;
                variables.opperformed = true;
                
            }
            else
            {
                variables.operation = button.Text;
                variables.result = Double.Parse(tbox.Text);
                    labelCO.Text = "History: " + variables.result + " " + variables.operation;
                variables.opperformed = true;
                    
            }
            variables.first = Convert.ToString(variables.result);

        }
    
        private void ce_click(object sender, EventArgs e)
        {
            variables.operation = "";
            variables.equal = false;
            variables.opperformed = false;
            tbox.Text = "0";
            variables.result = 0;
            labelCO.Text = "Clear Entry!";
        }

        private void c_click(object sender, EventArgs e)
        {
            variables.operation = "";
            variables.equal = false;
            variables.opperformed = false;
            tbox.Text = "0";
            variables.result = 0;
            variables.first = "First input = ";
            labelCO.Text = "Clear!";
            memorybox.Clear();
            if (memorybox.Text == "")
            {
                memorybox.Text = "Memory Cleared";
            }
        }

        private void equal_click(object sender, EventArgs e)
        {
            variables.equal = true;
            variables.second = tbox.Text;
        
            variables.tbox = tbox.Text;
            variables.Operations();
            tbox.Text = variables.tbox;
      
            memorybox.AppendText("\n" + variables.first + "  " + variables.operation + "  " + variables.second + "  = " + "\n");
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
