using System;

namespace IntegerCalculator
{
    public class Calculator: IntCalculator

    {
        public int Result { get; private set; }

        public void Reset()
        {
            Result = 0;
        }

        public void Add(int x)
        {
            if (x + Result < int.MaxValue && x + Result > int.MinValue)
            {
                Result += x;
            }
            else
            {
                throw new OverflowException();
            }
        }

        public void Subtract(int x)
        {
            if (Result - x > int.MinValue && Result - x < int.MaxValue) 
            {
                Result -= x;
            }
            else
            {
                throw new OverflowException();
            }
        }

        public void Multiply(int x)
        {
            if (x * Result < int.MaxValue && x * Result > int.MinValue)
            {
                Result *= x;
            }
            else
            {
                throw new OverflowException();
            }
        }

        public void Divide(int x)
        {
            if (x==0)
            {
                throw new ArgumentException();
            }
            if (Result / x > int.MinValue && Result / x < int.MaxValue)
            {
                Result /= x;
            }
            else
            {
                throw new OverflowException();
            }
        }

        public void Modulus(int x)
        {
            if (Result % x > int.MinValue && Result % x < int.MaxValue)
            {
                Result %= x;
            }
            else
            {
                throw new OverflowException();
            }
        }
    }
}