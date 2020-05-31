using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalc.Services
{
    public class CalcResults
    {
        private readonly Logger _logger;
        public CalcResults( Logger logger )
        {
            _logger = logger;
            _logger.Log("CalcResults init...");
        }

        public string Decorate( double arg1, double arg2, double calcResult, string operationType )
        {
            string result = "";
            _logger.Log("CalcResults Decorate...");

            switch (operationType)
            {
                case "Add":
                    result = $"{arg1} + {arg2} = {calcResult}";
                    break;
                case "Sub":
                    result = $"{arg1} - {arg2} = {calcResult}";
                    break;
                case "Mult":
                    result = $"{arg1} x {arg2} = {calcResult}";
                    break;
                case "Div":
                    result = $"{arg1} / {arg2} = {calcResult}";
                    break;
            }

            _logger.Log("CalcResults result = " + result);

            return result;
        }
    }
}
