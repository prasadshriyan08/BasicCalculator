using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Business
{
    public interface IBasicCalculatorService
    {
        double PerformCalculation(double firstNumber, double currentNumber, string previousOperation, string currentOperation);
    }
}
