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
            float n1 = a;
            float n2 = b;

            float result = -1;
            try
            {
                if (n1<0)
                {
                    throw new ArgumentOutOfRangeException("n1 必須為正整數");
                }
                if (n2 <0)
                {
                    throw new DivideByZeroException();
                }

                result = a / b;
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine(exp.ToString());
            }
            catch (ArgumentOutOfRangeException exp)
            {
                Console.WriteLine(exp.ToString());
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
