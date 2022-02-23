using Caso2Calc_Johanny_Vivas_Arias.Models;

namespace Caso2Calc_Johanny_Vivas_Arias.Logic
{
    public interface ILogic
    {
        Calculator GetCalculator();
        bool AddNumberOne(string number);
        bool AddNumberTwo(string number);
        bool SetOperator(string _operator);
        bool ResetCalculadora();
        bool GetResult();
        bool ResetNumber();

        bool ShowMcNumber();

        bool AddMcNumber();
        bool ResetMcNumber();
        bool McSumNumber();
        bool McResNumber();
    }
}
