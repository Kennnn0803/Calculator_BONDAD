using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_BONDAD
{
    class var
    {
       public Double result = 0;
       public String operation = "";
       public bool opperformed = false;
       public String first, second;
       public bool equal = false;
       public String tbox = "";

       public void Operations()
        {
            switch (operation)
            {
                case "+":
                    tbox = (result + Double.Parse(tbox)).ToString();
                    break;
                case "-":
                    tbox = (result - Double.Parse(tbox)).ToString();
                    break;
                case "/":
                    tbox = (result / Double.Parse(tbox)).ToString();
                    break;
                case "*":
                    tbox = (result * Double.Parse(tbox)).ToString();
                    break;
                case "√":
                    tbox= (Math.Sqrt(Double.Parse(tbox))).ToString();
                    break;
                case "X²":
                    tbox= (Math.Pow(Double.Parse(tbox), 2)).ToString();
                    break;
                case "X³":
                    tbox = (Math.Pow(Double.Parse(tbox), 3)).ToString();
                    break;
                case "Mod":
                    tbox = (result % Double.Parse(tbox)).ToString();
                    break;

                default:
                    break;
            }
        }

    }


}
