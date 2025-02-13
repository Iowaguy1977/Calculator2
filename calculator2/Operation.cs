using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    public class Operation
    {

        public double Add(double Firstnum, double Secondnum) 
        { 
            return Firstnum + Secondnum;
        
        
        }

        public double Subtract(double Firstnum, double Secondnum) 
        { 
            
            return Firstnum - Secondnum; 
        
        
        }
        public double Multiply(double Firstnum, double Secondnum) 
        { 
            
            
            return Firstnum * Secondnum; 
        
        
        }
        public double Divide(double Firstnum, double Secondnum) 
        {
            return Firstnum / Secondnum; 
        
        }

    }
}
