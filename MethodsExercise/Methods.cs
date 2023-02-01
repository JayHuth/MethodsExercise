using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Methods
    {
        public static int Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static int Subtract(int num1, int num2) 
        {
        int sum = num1 - num2;
            return sum;
        }

        public static int Divide(int num1, int num2)
        { 
        int sum = num1 / num2;
            return sum;
        }

        public static int add (int num1, int num2, int num3) 
        {
            int sum = num1 + num2 + num3;
            return sum;
        }
    }
}
