using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAvanced.DelegateBasis
{

    public delegate int MathOperation(int a, int b);
    internal class Clac
    {
        static public int Add(int a, int b) => a + b;
        static public int Multiply(int a, int b)
        {
            Console.WriteLine("Multiply");
            return a * b;
        }

        static public double Subtract(double a, double b) => a - b;

    }
}
