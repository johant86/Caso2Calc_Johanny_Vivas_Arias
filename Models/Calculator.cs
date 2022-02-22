using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caso2Calc_Johanny_Vivas_Arias.Models
{
    public class Calculator
    {
        public string NumberOne { set; get; }
        public string NumberTwo { set; get; }
        public string Operator { set; get; }
        public string result { set; get; }

        public Calculator()
        {
            result = "0";
            NumberOne = "";
            NumberTwo = "";
        }
    }
}
