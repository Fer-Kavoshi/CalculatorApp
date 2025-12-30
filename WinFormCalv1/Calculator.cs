// Class Calculator

namespace WinFormCalv1
{
    internal class Calculator
    {
        public string result;
        public string history;
        double _number;
        double _result;
        string _operation = "";
        public bool isDivide;
        public void Operator(string input, string operation)
        {
            history += $"{input} {operation} ";
            if (_operation == "")
            {
                if (input == "")
                {
                    _operation = operation;
                }
                else
                {
                    _result += Convert.ToDouble(input);
                    _operation = operation;
                }
            }
            else
            {
                try
                {
                    _number = Convert.ToDouble(input);
                    switch (_operation)
                    {
                        case "+":
                            {
                                _result += _number;
                                break;
                            }
                        case "-":
                            {
                                _result -= _number;
                                break;
                            }
                        case "*":
                            {
                                _result *= _number;
                                break;
                            }
                        case "/":
                            {
                                if (_number == 0)
                                {
                                    CeButton();
                                    result = null;
                                    MessageBox.Show("امکان تقسیم بر صفر وجود ندارد");
                                    break;
                                }
                                else
                                {
                                    _result = _result / _number;
                                    break;
                                }                                
                            }
                    }
                    _operation = operation;
                }
                catch (FormatException)
                {
                    _operation = operation;
                }
            }
            result= Convert.ToString(_result);         
        }
        public void CeButton()
        {
            _number = 0;
            _result = 0;
            _operation = "";
            history = null;
            result = null;
        }
    }
}
