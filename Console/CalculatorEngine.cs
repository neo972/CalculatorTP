using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            int res;

            

            if(b != 0)
            {
                res = a / b;
            } 
            else
            {
                res = Int32.MinValue;
            }

            return res;
        }
    }
}
