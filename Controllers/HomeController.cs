using Caso2Calc_Johanny_Vivas_Arias.Logic;
using Caso2Calc_Johanny_Vivas_Arias.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Caso2Calc_Johanny_Vivas_Arias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogic _logic;
        private  Calculator calculator = new Calculator();

        public HomeController(ILogic logic)
        {
            _logic = logic;
        }



        public IActionResult Index()
        {
            return View(calculator);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpPost]
        public dynamic AddNumer(string num)
        {
            try
            {
                calculator = _logic.GetCalculator();
                if (calculator.Operator != null)
                {

                    if (_logic.AddNumberTwo(num))
                        calculator = _logic.GetCalculator();
                }
                else
                {
                    if (_logic.AddNumberOne(num))
                        calculator = _logic.GetCalculator();
                }

                View();
                return calculator;
            }
            catch (Exception ex)
            {
                ViewBag.Result = ex.Message;
            }
            return View("CalPage");
        }

        [HttpPost]
        public dynamic SetOpetor(string _operator)
        {
            try
            {
                if (_logic.SetOperator(_operator))
                    calculator = _logic.GetCalculator();
                View(calculator);
                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }

        [HttpGet]
        public dynamic GetResult()
        {
            try
            {
                if (_logic.GetResult())
                    calculator = _logic.GetCalculator();

                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }

        [HttpPost]
        public dynamic ResetCalculadora()
        {
            try
            {
                if (_logic.ResetCalculadora())
                    calculator = _logic.GetCalculator();

                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }

        [HttpPost]
        public dynamic ResetNumber()
        {
            try
            {
                if (_logic.ResetNumber())
                    calculator = _logic.GetCalculator();

                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }


        [HttpPost]
        public dynamic AddMcNumber()
        {
            try
            {
                if (_logic.AddMcNumber())
                    calculator = _logic.GetCalculator();

                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }

        [HttpPost]
        public dynamic ShowMcNumber()
        {
            try
            {
                if (_logic.ShowMcNumber())
                    calculator = _logic.GetCalculator();

                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }

        [HttpPost]
        public dynamic McSumNumber()
        {
            try
            {
                if (_logic.McSumNumber())
                    calculator = _logic.GetCalculator();

                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }

        [HttpPost]
        public dynamic McResNumber()
        {
            try
            {
                if (_logic.McResNumber())
                    calculator = _logic.GetCalculator();

                return calculator;
            }
            catch (Exception)
            {
                ViewBag.Result = "Wrong Input Provided.";
            }
            return View("CalPage");
        }




    }
}
