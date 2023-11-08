using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Proyecto1Calculadora
{
    public static class clsCalculadora
    {
        public static float sum(float num1, float num2)
        {
            return (float)num1 + num2;
        }

        public static float subtraction(float num1, float num2)
        {
            return (float)num1 - num2;
        }

        public static float multiplication(float num1, float num2)
        {
            return (float) num1*num2;
        }

        public static float division(float num1, float num2)
        {
            return (float)num1 / num2;
        }

        public static float negate(float num1)
        {
            return -1 * num1;
        }

        public static float squareRoot(float num1)
        {
            return (float)Math.Sqrt(num1);
        }

        public static float power2(float num1)
        {
            return (float)Math.Pow(num1, 2);
        }

        public static float power(float num1, float num2)
        {
            return (float)Math.Pow(num1, num2);

        }

        public static float tenToThe(float num1)
        {
            return (float)Math.Pow(10, num1);
        }

        public static float factorial(float num1)
        {
            return (float)Math.Pow(num1, (num1-1)); //FOR??
        }

        public static float logarithm(float num1)
        {
            return (float)Math.Log10(num1);
        }


       public static string TrimLastCharacter(this string sender) =>
            string.IsNullOrWhiteSpace(sender) ?
            sender : sender.TrimEnd(sender[sender.Length - 1]);
       

    }
}