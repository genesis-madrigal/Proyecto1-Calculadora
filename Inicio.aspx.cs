using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto1Calculadora
{
    public partial class Inicio : System.Web.UI.Page
    {
        static clsGlobales clsGlobales = new clsGlobales();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsGlobales.num1 = 0;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
           lblCalculadora.Text = lblCalculadora.Text + "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
           lblCalculadora.Text = lblCalculadora.Text + "2";
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + "3";
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + "4";
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + "5";
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + "6";
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + "7";
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + "8";
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + "9";
        }

        protected void btnEquals_Click(object sender, EventArgs e)
        {
           
           clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));

            if (clsGlobales.operacion == "+")
            {
                lblResultado.Text = clsCalculadora.sum(clsGlobales.num1, clsGlobales.num2).ToString();
                clsGlobales.operacion = "";
                clsGlobales.num1 = float.Parse(lblResultado.Text);
                clsGlobales.num2 = 0;

            }
            else if (clsGlobales.operacion == "-")
            {
               lblResultado.Text = clsCalculadora.subtraction(clsGlobales.num1, clsGlobales.num2).ToString();
               clsGlobales.operacion = "";
            }
            else if (clsGlobales.operacion == "*")             {
                lblResultado.Text = clsCalculadora.multiplication(clsGlobales.num1, clsGlobales.num2).ToString();
                clsGlobales.operacion = "";
            }
            else if (clsGlobales.operacion == "/")
            {
                if(clsGlobales.num1 != 0)
                {
                    lblResultado.Text = clsCalculadora.division(clsGlobales.num1, clsGlobales.num2).ToString();
                    clsGlobales.operacion = "";
                }
                else if (clsGlobales.num1 == 0)
                {
                    lblResultado.Text = (0).ToString();
                }

            }
            else
            {
                clsGlobales.num2 = 1;
                lblResultado.Text = lblCalculadora.Text;
                lblTest1.Text = "Num1: " + clsGlobales.num1 + " Num2: " + clsGlobales.num2 + " lblCalculadora: " + lblCalculadora.Text;
            }
            
           // lblCalculadora.Text = string.Empty;
           // clsGlobales.num1 = float.Parse(lblResultado.Text);
        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            clsGlobales.operacion = "+";
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);// DI SI            
            lblCalculadora.Text = lblCalculadora.Text + " + ";
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            clsGlobales.operacion = "-";
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblCalculadora.Text = lblCalculadora.Text + " - ";
            clsGlobales.terminado = true;
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            clsGlobales.operacion = "*";
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblCalculadora.Text = lblCalculadora.Text + " x ";
            clsGlobales.terminado = true;
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            clsGlobales.operacion = "/";
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblCalculadora.Text = lblCalculadora.Text + " ÷ ";
            clsGlobales.terminado = true;
        }

        protected void btnComma_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = lblCalculadora.Text + ",";
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
             lblCalculadora.Text = lblCalculadora.Text + "0";
        }

        protected void btnNegate_Click(object sender, EventArgs e)
        {
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblResultado.Text = clsCalculadora.negate(clsGlobales.num1).ToString();
            lblCalculadora.Text = lblResultado.Text;

        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblResultado.Text = clsCalculadora.logarithm(clsGlobales.num1).ToString();
            lblCalculadora.Text = "log(" + (clsGlobales.num1).ToString() + ")";

        }

        protected void btnSQR_Click(object sender, EventArgs e)
        {
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblResultado.Text = clsCalculadora.squareRoot(clsGlobales.num1).ToString();
            lblCalculadora.Text = "√" + (clsGlobales.num1).ToString();
        }

        protected void btnSquare_Click(object sender, EventArgs e)
        {
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblResultado.Text = clsCalculadora.power2(clsGlobales.num1).ToString();
            lblCalculadora.Text = (clsGlobales.num1).ToString() + "²";
        }

        protected void btnXtotheY_Click(object sender, EventArgs e)
        {
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            clsGlobales.num2 = float.Parse(lblCalculadora.Text); //*******hacer que sirva el num2
            lblResultado.Text = clsCalculadora.power2(clsGlobales.num1).ToString();
            lblCalculadora.Text = (clsGlobales.num1).ToString() + "^" + (clsGlobales.num2).ToString();
        }

        protected void btn10totheX_Click(object sender, EventArgs e) //hacer que el 10 se ponga primero antes del numero al que lo elevo?? sirve solo si pongo el numero primero y luego el 10 elevado
        {
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblResultado.Text = clsCalculadora.tenToThe(clsGlobales.num1).ToString();
            lblCalculadora.Text = "10^" + (clsGlobales.num1).ToString();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblCalculadora.Text = clsCalculadora.TrimLastCharacter(lblCalculadora.Text);  //sirve pero si hay dos del mismo numero ex66 me borra ambos en lugar de solo 1 ???
        }
    }
}