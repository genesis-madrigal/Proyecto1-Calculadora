﻿using System;
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
           
           

            if (clsGlobales.operacion == "+")
            {
                clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));

                //01234
                //25+10
                //int indexOperador = lblCalculadora.Text.IndexOf(clsGlobales.operacion);
                //string textoNum2 = lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1); //10
                //clsGlobales.num2 = float.Parse(textoNum2);


                lblResultado.Text = clsCalculadora.sum(clsGlobales.num1, clsGlobales.num2).ToString();
                clsGlobales.operacion = "";
                clsGlobales.num1 = float.Parse(lblResultado.Text);
                clsGlobales.num2 = 0;

            }
            else if (clsGlobales.operacion == "-")
            {
                if (clsGlobales.num1 != 0)
                {
                    clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));
                    lblResultado.Text = clsCalculadora.subtraction(clsGlobales.num1, clsGlobales.num2).ToString();
                    clsGlobales.operacion = "";
                }
                else
                {
                    clsGlobales.num1 = 0;
                    clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));
                    lblResultado.Text = clsCalculadora.subtraction(clsGlobales.num1, clsGlobales.num2).ToString();
                    clsGlobales.operacion = "";
                }

            }
            else if (clsGlobales.operacion == "*")             
            {
                clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));
                lblResultado.Text = clsCalculadora.multiplication(clsGlobales.num1, clsGlobales.num2).ToString();
                clsGlobales.operacion = "";
            }
            else if (clsGlobales.operacion == "/")
            {
                clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));
                if (clsGlobales.num1 != 0)
                {
                    lblResultado.Text = clsCalculadora.division(clsGlobales.num1, clsGlobales.num2).ToString();
                    clsGlobales.operacion = "";
                }
                else if (clsGlobales.num1 == 0)
                {
                    lblResultado.Text = (0).ToString();
                }
            }
            else if (clsGlobales.operacion == "10^")            
            {
                clsGlobales.num1 = float.Parse(lblCalculadora.Text.Substring(3));
                lblResultado.Text = clsCalculadora.tenToThe(clsGlobales.num1).ToString();
                lblCalculadora.Text = "10^" + (clsGlobales.num1).ToString();
            }
            else if (clsGlobales.operacion == "^")
            {
                clsGlobales.num1 = float.Parse(lblCalculadora.Text.Substring(0, (lblCalculadora.Text.IndexOf(clsGlobales.operacion)) -1));
                clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));
                lblResultado.Text = clsCalculadora.power(clsGlobales.num1, clsGlobales.num2).ToString();
            }
            else
            {
                
                lblResultado.Text = lblCalculadora.Text;
                lblTest1.Text = "Num1: " + clsGlobales.num1 + " Num2: " + clsGlobales.num2 + " lblCalculadora: " + lblCalculadora.Text;
            }
            
           //lblCalculadora.Text = string.Empty;
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

            if (clsGlobales.num1 != 0)
            {
                clsGlobales.num1 = float.Parse(lblCalculadora.Text);
                lblCalculadora.Text = lblCalculadora.Text + " - ";
            }
            else
            {
                clsGlobales.num1 = 0;
                lblCalculadora.Text = clsGlobales.num1 + " - ";
            }

        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            clsGlobales.operacion = "*";
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblCalculadora.Text = lblCalculadora.Text + " x ";
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            clsGlobales.operacion = "/";
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);
            lblCalculadora.Text = lblCalculadora.Text + " ÷ ";
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
            if (lblCalculadora.Text.Length != 0)
            {
                clsGlobales.num1 = float.Parse(lblCalculadora.Text.Substring(0, (lblCalculadora.Text.IndexOf(clsGlobales.operacion)) - 1));
                clsGlobales.num2 = float.Parse(lblCalculadora.Text.Substring(lblCalculadora.Text.IndexOf(clsGlobales.operacion) + 1));
                lblCalculadora.Text = (clsGlobales.num1).ToString() + "^" + (clsGlobales.num2).ToString();
                lblResultado.Text = clsCalculadora.power(clsGlobales.num1, clsGlobales.num2).ToString();
            }
            else
            {
                lblCalculadora.Text = (clsGlobales.num1).ToString() + "^" + (clsGlobales.num2).ToString();
                clsGlobales.operacion = "^";
            }
        }

        protected void btn10totheX_Click(object sender, EventArgs e) 
        {
            if(lblCalculadora.Text.Length != 0)
            {
                clsGlobales.num1 = float.Parse(lblCalculadora.Text);
                lblResultado.Text = clsCalculadora.tenToThe(clsGlobales.num1).ToString();
                lblCalculadora.Text = "10^" + (clsGlobales.num1).ToString();
            }
            else
            {
                lblCalculadora.Text = "10^";
                clsGlobales.operacion = "10^";
            }            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblCalculadora.Text.Length - 1 == 0)
            {
                lblCalculadora.Text = "0";
            }
            else
            {
                lblCalculadora.Text = lblCalculadora.Text.Remove(lblCalculadora.Text.Length - 1, 1);
            }
        }

        protected void btnFact_Click(object sender, EventArgs e)
        {
            clsGlobales.num1 = float.Parse(lblCalculadora.Text);  

            lblCalculadora.Text = clsCalculadora.factorial(clsGlobales.num1).ToString();            
        }
    }
}