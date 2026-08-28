using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAvanced
{
    internal class Helper
    {
        static public void PrintList<T>(List<T> numbers, String listName)
        {
            if (numbers is not null && numbers.Count > 0 && !string.IsNullOrEmpty(listName))
            {
                Console.WriteLine($"List: {listName} => {string.Join(", ", numbers)}");
            }
        }
    }
}
