﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1Calculadora
{
    public class clsGlobales
    {
        public float num1 { get; set; }
        public float num2 { get; set; }

        public bool terminado { get; set; }

        public float resultado { get; set; }


        public string operacion = "";

        public clsGlobales()
        {
            num1 = 0.0f;
            num2 = 0.0f;    
            resultado = 0.0f;
        }


    }

}