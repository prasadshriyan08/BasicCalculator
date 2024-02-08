using BasicCalculator.Business;
using System.Reflection.Metadata.Ecma335;

namespace BasicCalculator.UI
{
    //enum to check which button is clicked
    public enum ClickedButtonType
    {
        Number,
        Operator
    }

    public partial class Form1 : Form
    {
        IBasicCalculatorService basicCalculatorService;

        private double _firstNumber = 0;
        private double _currentNumber = 0;
        private string _currentOperation = "";
        private string _previousOperation = "";
        private bool _isNewNumber = true;
        private ClickedButtonType clickedButtonType;

        private string ResultValue { get { return txt_Total.Text; } set { txt_Total.Text = value; } }

        public Form1(IBasicCalculatorService Service)
        {
            basicCalculatorService = Service;
            InitializeComponent();
        }

        //event for "=" button click
        private void btn_eq_Click(object sender, EventArgs e)
        {
            _previousOperation = _currentOperation;
            Calculate();
            _isNewNumber = true;
        }

        //event for "numbers" button click
        private void number_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_isNewNumber)
            {
                ResultValue = button.Text;
                _isNewNumber = false;
            }
            else
            {
                ResultValue += button.Text;
            }

            _currentNumber = Double.Parse(ResultValue);
            clickedButtonType = ClickedButtonType.Number;

        }

        //event for "clear" button click
        private void btn_clr_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //event for "Decimal" button click
        private void btn_dec_Click(object sender, EventArgs e)
        {
            //check to have only one decimal point in the numbers 
            if (!ResultValue.Contains("."))
            {
                Button dec = (Button)sender;
                if (clickedButtonType == ClickedButtonType.Operator)
                {
                    ResultValue = "0";
                }

                ResultValue += dec.Text;
            }
        }

        //event for "Operator" button click
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _currentOperation = button.Text;

            if (_previousOperation == "" || clickedButtonType == ClickedButtonType.Operator)
            {
                if (_previousOperation == "")
                {
                    _firstNumber = _currentNumber;
                }

                _previousOperation = _currentOperation;
            }
            else
            {
                Calculate();
            }

            _isNewNumber = true;

            _currentNumber = double.Parse(ResultValue);
            clickedButtonType = ClickedButtonType.Operator;
        }

        //event to handle text edit operation
        private void txt_Total_MouseLeave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            ResultValue = tb.Text;
            _currentNumber = Double.Parse(tb.Text);
        }

        //function to calculate the values
        private void Calculate()
        {
            //call to business layer to calculate the numbers
            _firstNumber = basicCalculatorService.PerformCalculation(_firstNumber, _currentNumber, _previousOperation, _currentOperation);

            ResultValue = _firstNumber.ToString();
            _previousOperation = _currentOperation;
        }

        //function to set all values to default values
        private void Clear()
        {
            _firstNumber = 0;
            _currentNumber = 0;
            _currentOperation = "";
            _previousOperation = "";
            _isNewNumber = true;
            ResultValue = "0";
        }

    }
}