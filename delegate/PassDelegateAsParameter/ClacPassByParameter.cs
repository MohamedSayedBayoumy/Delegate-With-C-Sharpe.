using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAvanced.PassDelegateAsParameter
{
    public delegate bool FiliterDelegate(int number);

    internal class ClacPassByParameter
    {
        #region Problem => Here In two Function we have same logic but only different in condition so we can use delegate to solve this problem
        //static public List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> evenNumbers = new();
        //    if (numbers is not null && numbers.Count > 0)
        //    {
        //        foreach (var number in numbers)
        //        {
        //            if (number % 2 == 0) // Here this is only different Logic 
        //            {
        //                evenNumbers.Add(number);
        //            }

        //        }
        //        return evenNumbers;
        //    }
        //    return [];
        //}

        //static public List<int> GetOddNumbers(List<int> ListOfNumbers)
        //{
        //    List<int> numbers = new();

        //    if (ListOfNumbers != null && ListOfNumbers.Count > 0)
        //    {
        //        foreach (var item in numbers)
        //        {
        //            if (item % 2 != 0) // Here this is only different Logic 
        //            {
        //                numbers.Add(item);
        //            }

        //        }
        //        return numbers;
        //    }
        //    return [];
        //}
        #endregion

        #region Soluation
        public bool IsEven(int number) => number % 2 == 0;
        public bool IsOdd(int number) => number % 2 != 0;

        public List<int> FiliterNumber(List<int> listOfNumbers, FiliterDelegate filiterDelegate)
        {

            List<int> numbersAfterFiliter = new();

            if (listOfNumbers is not null && listOfNumbers.Count > 0 && filiterDelegate is not null)
            {
                foreach (var number in listOfNumbers)
                {
                    if (filiterDelegate.Invoke(number))
                    {
                        numbersAfterFiliter.Add(number);
                    }
                }
                return numbersAfterFiliter;
            }

            return [];
        }
        #endregion
    }
}

