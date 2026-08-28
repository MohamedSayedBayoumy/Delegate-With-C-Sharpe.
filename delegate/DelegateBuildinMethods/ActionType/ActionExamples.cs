using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAvanced.DelegateBuildinMethods.ActionType
{
    internal class ActionExamples
    {
        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        public void Run(string name , int countOfLeg , bool sleeped)
        {
            string sleepStatus = sleeped ? "sleeping" : "not sleeping";
            Console.WriteLine($"Running... , He is {name}, has {countOfLeg} legs, and is {sleepStatus}");
        }
    }
}
