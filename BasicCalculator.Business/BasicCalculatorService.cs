using log4net;
using BasicCalculator.DataAccess;
namespace BasicCalculator.Business
{
    public class BasicCalculatorService:IBasicCalculatorService
    {
        private readonly IBasicCalculatorRepository _repository;
        private readonly ILog _logger;

        private int _numberofDecimalValues = 5;

        public BasicCalculatorService(IBasicCalculatorRepository repository, ILog logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public double PerformCalculation(double firstNumber, double currentNumber, string previousOperation, string currentOperation)
        {
            try
            {
                _logger.Info("Entered PerformCalculation Method");
                return Calculate(firstNumber, currentNumber, previousOperation, currentOperation);
            }
            catch (Exception ex)
            {
                // Log errors using _logger
                _logger.Error(ex.Message);
                throw;
            }
        }

        private double Calculate(double firstNumber, double currentNumber,string previousOperation, string currentOperation)
        {
            switch (previousOperation)
            {
                case "+":
                    firstNumber += currentNumber;
                    break;
                case "-":
                    firstNumber -= currentNumber;
                    break;
                case "*":
                    firstNumber *= currentNumber;
                    break;
                case "/":
                    if (currentNumber != 0)
                    {
                        firstNumber = Math.Round(firstNumber /= currentNumber, _numberofDecimalValues);
                    }
                    else
                    {
                        firstNumber = 0;
                    }
                    break;
            }

            previousOperation = currentOperation;
            return firstNumber;
        }
    }
}