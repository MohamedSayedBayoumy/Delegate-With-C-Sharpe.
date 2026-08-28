using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAvanced.MultiCastDelegate
{

    public delegate void HouseKeepingDelegate(string action);
    internal class HouseKeeper
    {
        public void Wash(string action)
        {
            Console.WriteLine($"{action} Wash");
        }

        public void Clean(string action)
        {
            Console.WriteLine($"{action} Clean");
        }

        public void Run(string action)
        {
            Console.WriteLine($"{action} Run");
        }
    }
}
