using DelegateAvanced;
using DelegateAvanced.DelegateBasis;
using DelegateAvanced.PassDelegateAsParameter;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Basic
            //MathOperation mathOperation = Clac.Add;

            //var resultWithInvoke = mathOperation.Invoke(10, 20);
            //var result = mathOperation(10, 20);
            //Console.WriteLine($"Result with Invoke: {resultWithInvoke}");
            //Console.WriteLine($"Result With Syntax Sugar: {result}");

            //Console.WriteLine("=======================================");

            //mathOperation = Clac.Multiply;
            //var resultMultiply = mathOperation.Invoke(10, 20);
            //Console.WriteLine($"Result Multiply: {resultMultiply}");


            //// mathOperation = Clac.Subtract; //  Here will give error Cause Subtract Fun not Match the Delegate Singnature
            #endregion

            #region Pass Delegate As Parameter
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //ClacPassByParameter calc = new ClacPassByParameter();

            //List<int> evenNumbers = calc.FiliterNumber(numbers, calc.IsEven);
            //Helper.PrintList<int>(evenNumbers, "Even Numbers");


            //FiliterDelegate filterDelegate = calc.IsOdd;
            //List<int> oddNumbers = calc.FiliterNumber(numbers, filterDelegate);
            //Helper.PrintList<int>(oddNumbers, "Odd Numbers");
            #endregion


        }
    }
}
