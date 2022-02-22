using Caso2Calc_Johanny_Vivas_Arias.Logic;
using Caso2Calc_Johanny_Vivas_Arias.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caso2Calc_Johanny_Vivas_Arias
{
    public class LogicClass : ILogic
    {
        private Calculator calculator = new Calculator();
        public bool AddNumberOne(string number)
        {
            try
            {
                calculator.NumberOne = "";
                string numb = calculator.NumberOne;
                numb += number;



                calculator.NumberOne = numb;
                calculator.result = calculator.NumberOne;

              
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return true;
        }

        public bool AddNumberTwo(string number)
        {
            try
            {
                calculator.NumberTwo = "";
                string numb = calculator.NumberTwo;
                numb += number;

                calculator.NumberTwo = numb;
                calculator.result = calculator.NumberTwo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public Calculator GetCalculator()
        {
            return calculator;
        }

        public bool GetResult()
        {
            try
            {
                if (calculator.Operator != null)
                {
                    switch (calculator.Operator)
                    {
                        case "+":
                            calculator.result = (Decimal.Parse(calculator.NumberOne) + Decimal.Parse(calculator.NumberTwo)).ToString();
                            break;

                        case "-":
                            calculator.result = (float.Parse(calculator.NumberOne) - float.Parse(calculator.NumberTwo)).ToString();
                            break;

                        case "/":
                            calculator.result = (float.Parse(calculator.NumberOne) / float.Parse(calculator.NumberTwo)).ToString();
                            break;
                        case "*":
                            calculator.result = (float.Parse(calculator.NumberOne) * float.Parse(calculator.NumberTwo)).ToString();
                            break;

                        default:
                            calculator.result = "0";
                            break;
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetCalculadora()
        {
            try
            {
                if (calculator != null)
                {
                    calculator = new Calculator();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetNumber()
        {
            try
            {
                if (calculator.Operator != null)
                {
                    calculator.NumberTwo = "0";
                    return true;
                }
                else
                    calculator.NumberOne = "0";
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SetOperator(string _operator)
        {
            try
            {
                if (calculator != null)
                {
                    calculator.Operator = _operator;
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
