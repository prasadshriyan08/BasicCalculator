using BasicCalculator.Business;
using BasicCalculator.DataAccess;
using log4net;


namespace BasicCalculator.UI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IBasicCalculatorRepository repository = new BasicCalculatorRepository();
            ILog logger = LogManager.GetLogger(typeof(Program));
            IBasicCalculatorService service = new BasicCalculatorService(repository, logger);
            
            Application.Run(new Form1(service));
        }
    }
}