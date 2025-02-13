using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    public class StepKeeper
    {
        public enum Step {FirstStep,SecondStep,ThirdStep,FinalStep }

        public StepKeeper()
        {
            this.CalculationStep = Step.FirstStep;
        }

        public Step CalculationStep { get; set; }
    }
}
