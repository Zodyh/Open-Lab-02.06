using System;

namespace Open_Lab_02._06
{
    public class Calculator
    {
        public bool Divisible(int number)
        {
            int sto = number % 100;
            if (sto == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
