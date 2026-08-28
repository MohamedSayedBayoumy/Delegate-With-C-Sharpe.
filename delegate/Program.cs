using DelegateAvanced;
using DelegateAvanced.DelegateBasis;
using DelegateAvanced.DelegateBuildinMethods.ActionType;
using DelegateAvanced.MultiCastDelegate;
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

            #region MultiCast Delegate 

            #region MultiCast Delegate With void return type
            //HouseKeeper houseKeeper = new();
            //HouseKeepingDelegate? houseKeepingDelegate;
            //houseKeepingDelegate = houseKeeper.Wash;
            //houseKeepingDelegate += houseKeeper.Clean;

            //houseKeepingDelegate.Invoke("Delegate");

            //houseKeepingDelegate -= houseKeeper.Wash;

            //Console.WriteLine("After Remove");
            //houseKeepingDelegate?.Invoke("Delegate"); 
            #endregion

            #region MultiCast Delegate With return type
            //Zoo zoo = new();
            //ZooDelegate? zooDelegate ;

            //zooDelegate = zoo.Lion;
            //zooDelegate += zoo.Dog;
            //zooDelegate += zoo.Cat;

            //var result   = zooDelegate.Invoke("Delegate");

            //Console.WriteLine(result); // Here delegate will Trigger all of fun was added , result will be "Delegate Cat" cause they have return type 
            #endregion

            #endregion

            #region Delegate Buildin Methods
            #region Action (Generic - non Generic)
            //ActionExamples actionExamples = new();

            //Action nonGenericAction = actionExamples.Play;

            //nonGenericAction.Invoke();

            //Action<string , int , bool> genericAction = actionExamples.Run;

            //genericAction.Invoke("Mohamed" , 0 , false);

            #endregion

            #region Predicate

            #endregion

            #region Func

            #endregion

            #endregion

        }
    }
}
