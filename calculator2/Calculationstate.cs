using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    public class CalculationState
    {
        private double _FirstNumber = 0;
        private double _SecondNumber = 0;
        private string _Operation=string.Empty;
        private string _fullProblem=string.Empty;
        private double _Sum=0;
       


        public double FirstNumber

        {
            get { return _FirstNumber; }


            set { _FirstNumber = value; }
        }

        public double Secondnumber

        {
            get { return _SecondNumber; }


            set { _SecondNumber = value; }
        }
        public void SetProblem()
        {
            _fullProblem = _FirstNumber + " " + Operation + " " + _SecondNumber + " " + " = " + Convert.ToString(_Sum);
        }
        public string Operation 
        { 
            get { return _Operation; } 
            
            set { _Operation = value; } 
        }
        public string FullProblem
        {
            get { return _fullProblem; }
            set { _fullProblem = value; }
        }
        public void RunCalculation()
        {
            if(_Operation == "+")
            {
                _Sum = _FirstNumber + _SecondNumber;
            }
            if(_Operation == "-")
            {
                _Sum=_FirstNumber - _SecondNumber;
            }
            if (_Operation == "*")
            {
                _Sum = _FirstNumber * _SecondNumber;
            }
            if (_Operation == "/") { 
               _Sum= _FirstNumber / _SecondNumber;
            }
        }
        public double ReturnSum
        {
            get { return _Sum; }

        }
        public void ClearAll()
        {
            _Sum = 0;
            _FirstNumber = 0;
            _SecondNumber = 0;
            _Operation = string.Empty;
        }
       
    }
}
