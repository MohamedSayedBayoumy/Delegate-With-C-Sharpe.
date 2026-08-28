using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAvanced.MultiCastDelegate
{
    public delegate string ZooDelegate(string action);
    internal class Zoo
    {
        public string Cat(string action)
        {
            return $"{action} Cat";
        }

        public string Dog(string action)
        {
            return $"{action} Dog";
        }

        public string Lion(string action)
        {
            return $"{action} Lion";
        }
    }
}
