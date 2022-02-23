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

        public bool ShowMcNumber()
        {
            try
            {
                if (calculator != null)
                {
                    if (calculator.Operator != null)
                    {
                        calculator.NumberTwo = calculator.McNumberTwo;
                        calculator.result = calculator.NumberOne;

                    }
                    else
                    {
                        calculator.McNumberOne = calculator.McNumberOne;
                        calculator.result = calculator.McNumberTwo;
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

        public bool AddNumberOne(string number)
        {
            try
            {

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

                        case "%":
                            calculator.result = (float.Parse(calculator.NumberOne) % float.Parse(calculator.NumberTwo)).ToString();
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
                    calculator.NumberTwo = "";
                    calculator.result = "0";
                    return true;
                }
                else
                    calculator.NumberOne = "";
                calculator.result = "0";
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

        public bool AddMcNumber()
        {
            try
            {
                if (calculator != null)
                {
                    if (calculator.Operator != null)
                    {
                        calculator.McNumberTwo = calculator.NumberTwo;
                        //calculator.result = calculator.NumberOne;
                    }
                    else
                    {
                        calculator.McNumberOne = calculator.McNumberOne;
                        // calculator.result = calculator.McNumberTwo;
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

        public bool ResetMcNumber()
        {
            try
            {
                if (calculator != null)
                {

                    calculator.McNumberTwo = "0";
                    calculator.McNumberOne = "0";

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

        public bool McSumNumber()
        {
            try
            {
                if (calculator != null)
                {
                    if (calculator.Operator != null)
                    {
                        string memory = calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo;
                        string calc = (Decimal.Parse(calculator.NumberOne) + Decimal.Parse(calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo)).ToString();
                        calculator.result = $"{calculator.NumberOne} + {memory} ={calc}";//(Decimal.Parse(calculator.NumberTwo) + Decimal.Parse(calculator.McNumberOne)).ToString();
                    }
                    else
                    {
                        string memory = calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo;
                        string calc = (Decimal.Parse(calculator.NumberOne) + Decimal.Parse(calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo)).ToString();
                        calculator.result = $"{calculator.NumberOne} + {memory} = { calc}";
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

        public bool McResNumber()
        {
            try
            {
                if (calculator != null)
                {
                    if (calculator.Operator != null)
                    {
                        string memory = calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo;
                        string calc = (Decimal.Parse(calculator.NumberOne) - Decimal.Parse(calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo)).ToString();
                        calculator.result = $"{calculator.NumberOne} + {memory} ={calc}";//(Decimal.Parse(calculator.NumberTwo) + Decimal.Parse(calculator.McNumberOne)).ToString();
                    }
                    else
                    {
                        string memory = calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo;
                        string calc = (Decimal.Parse(calculator.NumberOne) - Decimal.Parse(calculator.NumberOne != "" ? calculator.NumberOne : calculator.NumberTwo)).ToString();
                        calculator.result = $"{calculator.NumberOne} + {memory} = { calc}";
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
    }
}
