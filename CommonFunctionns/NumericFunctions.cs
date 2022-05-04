using System;

namespace CommonFunctionns
{
    public class NumericFunctions
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public bool IsEven(int x)
        {
            //if (x % 2 == 0) return true; else return false;
            // ?:
            return x % 2 == 0 ? true : false;
        }
    }
}
