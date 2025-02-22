using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace calculator2

{

    public partial class Form1 : Form
    {
        private readonly StepKeeper _stepKeeper;
        private CalculationState _CalculationState;
        private double number = 0;
        private Boolean adddecimal=false;
        private String _operation=string.Empty;
        private String num = string.Empty;
        private List<String> problem = new List<String>();
        private Boolean _problemSolved = false;
        public Form1(StepKeeper stepKeeper, CalculationState calculationState)
        {
                   InitializeComponent();
                   this._stepKeeper = stepKeeper;
                   _CalculationState = calculationState;
        }

        public void NumberClick(object sender, EventArgs e)
        {
            if (_problemSolved)
            {
                _problemSolved=false;
                _CalculationState.ClearAll();
                SumWindow.Text = "0";
                _operation = string.Empty;
                CalculationWindow.Text = null;
                _stepKeeper.CalculationStep = StepKeeper.Step.FirstStep;
                number = 0;
                num = string.Empty;
            }

            if (_stepKeeper.CalculationStep == StepKeeper.Step.FirstStep)
            {

                if (sender.GetType() == typeof(Button))
                {
                    Button button = (Button)sender;
                    checkForDecimal();
                    updateNumber(button);
                    updateOperation(button.Text);
                    updateWindows();
                        

                }
            }

            if (_stepKeeper.CalculationStep == StepKeeper.Step.SecondStep)
            {
                    SumWindow.Clear();

                if (sender.GetType() == typeof(Button))
                {
                    Button button = (Button)sender;
                    checkForDecimal();
                    updateNumber(button);
                    updateOperation(button.Text);
                    updateWindows();
                }
            }
            if (_stepKeeper.CalculationStep == StepKeeper.Step.ThirdStep)
            {
             
                    SumWindow.Clear();

                if (sender.GetType() == typeof(Button))
                {
                    Button button = (Button)sender;
                    checkForDecimal();
                    updateNumber(button);
                    updateOperation(button.Text);
                    _CalculationState.FirstNumber = _CalculationState.ReturnSum;
                    _CalculationState.Secondnumber = number;
                    updateWindows();
                }
            }

        }
        public void OperationClick(object sender, EventArgs e)
        {
            if (_problemSolved)
            {
               _stepKeeper.CalculationStep = StepKeeper.Step.FirstStep;
                number=_CalculationState.ReturnSum;
                _problemSolved = false;
            }            
            
                if (_stepKeeper.CalculationStep == StepKeeper.Step.ThirdStep)
                {
                    _CalculationState.RunCalculation();
                    if (sender.GetType() == typeof(Button))
                    {

                        Button button = (Button)sender;
                        updateOperation(button.Text);
                        _stepKeeper.CalculationStep = StepKeeper.Step.ThirdStep;
                        _CalculationState.FirstNumber = _CalculationState.ReturnSum;
                        _CalculationState.Secondnumber = number;
                        number = 0;
                        SumWindow.Text = Convert.ToString(_CalculationState.ReturnSum);
                        _CalculationState.Operation = button.Text;
                        num = string.Empty;
                    }
                }
                if (_stepKeeper.CalculationStep == StepKeeper.Step.SecondStep)
                {
                    if (sender.GetType() == typeof(Button))
                    {

                        Button button = (Button)sender;
                        updateOperation(button.Text);
                        _stepKeeper.CalculationStep = StepKeeper.Step.ThirdStep;
                        _CalculationState.Secondnumber = number;
                        _CalculationState.RunCalculation();
                        number = 0;
                        _CalculationState.Operation = button.Text;
                        SumWindow.Text = Convert.ToString(_CalculationState.ReturnSum);
                        num = string.Empty;

                    }
                }


                if (_stepKeeper.CalculationStep == StepKeeper.Step.FirstStep)
                {
                        _CalculationState.FirstNumber = number;
                        _stepKeeper.CalculationStep = StepKeeper.Step.SecondStep;
                    if (sender.GetType() == typeof(Button))
                    {

                        Button button = (Button)sender;
                        _CalculationState.Operation = button.Text;
                        updateOperation(button.Text);
                        CalculationWindow.Text = _operation;
                        number = 0;
                        adddecimal = false;
                        num = string.Empty;

                    }

                }

            
        }
        public void DecimalClick(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                       adddecimal = true;
                       Button button = (Button)sender;
                       updateOperation(button.Text);
                       SumWindow.Text=_operation;
            }

        }
        public void ClearButtomClick(object sender,EventArgs e)
        {
                      _CalculationState.ClearAll();
                      SumWindow.Text = "0";
                      _operation=string.Empty;
                      CalculationWindow.Text = null;
                      _stepKeeper.CalculationStep= StepKeeper.Step.FirstStep;
                      number = 0;
                      num=string.Empty;

        }
        public void EqualsClick(object sender, EventArgs e)
        {
                      _CalculationState.Secondnumber = number;
            if (sender.GetType() == typeof(Button))
            {
                if (_CalculationState.FirstNumber == 0)
                {
                      MessageBox.Show("You must enter First number");
                      return;
                }
                if (_CalculationState.Secondnumber == 0)
                {
                      MessageBox.Show("You must enter second number");
                      return;
                }
                else
                {
                    Button button = (Button)sender;

                    if (_CalculationState.Secondnumber == 0)
                    {
                        _CalculationState.Secondnumber = number;
                    }
                       _CalculationState.RunCalculation();
                       SumWindow.Text = Convert.ToString(_CalculationState.ReturnSum);
                       _CalculationState.SetProblem();
                       problem.Add(Convert.ToString(_CalculationState.FullProblem));
                }
                       
            }
            _problemSolved = true;
        }
        public void BackSpaceClick(object sender, EventArgs e)
        {
            
            if (num.Length >0 && _operation.Length>0)
            {
                      num = num.Remove(num.Length-1, 1);
                      _operation = _operation.Remove(_operation.Length-1, 1);
                if (num.Length > 0)
                {
                    if (num == ".")
                    {
                      num = string.Empty;
                    return;
                    }
                    else
                    {
                      number = Convert.ToDouble(num);
                    }
                }
                else
                {
                      number = 0;
                }
            }
            
                      CalculationWindow.Text = _operation;
            if (num.Length == 0) { 
                      num = "0";
            
            }
                      SumWindow.Text= num;
                      number=Convert.ToDouble(SumWindow.Text);
        }
       public void updateOperation(string button)
        {
                      _operation =_operation + "" + button;
        }
        public void updateWindows()
        {
                      CalculationWindow.Text = _operation;
                      SumWindow.Text = number.ToString();
        }
        public void checkForDecimal()
        {
            if (adddecimal)
            {
                      adddecimal = false;
                      num = num + ".";

            }
        }
        public void updateNumber(Button button)
        {
                      num = num + button.Text;
                      number = double.Parse(num);
        }

        public void HistoryClick(object sender, EventArgs e)
        {
            for(int i=0; i < problem.Count; i++)
            {
                MessageBox.Show(Convert.ToString(problem.ElementAt(i)));
            }
        }

    }
}
