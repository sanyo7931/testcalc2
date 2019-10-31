using System;
using System.Collections.Generic;
using System.Text;

namespace Propram
{
    public class Calclators
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
        public float Div(float a, float b)
        {
            float result = -1;
            try
            {
                result = a / b;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }

    }
}
