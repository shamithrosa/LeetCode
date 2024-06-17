using System;

namespace LeetCode.Questions.Medium
{
    public class Q29
    {
        public int Divide(int dividend, int divisor)
        {
            // Handle division by zero
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            // Handle overflow
            if (dividend == Int32.MinValue && divisor == -1)
            {
                return Int32.MaxValue;
            }

            // Determine the sign of the result
            bool negative = (dividend < 0) ^ (divisor < 0);

            // Convert to long to avoid overflow and get absolute values
            long absDividend = Math.Abs((long)dividend);
            long absDivisor = Math.Abs((long)divisor);

            // Initialize the result
            long result = 0;

            // Perform division using bit manipulation
            while (absDividend >= absDivisor)
            {
                long tempDivisor = absDivisor;
                long multiple = 1;

                while (absDividend >= (tempDivisor << 1))
                {
                    tempDivisor <<= 1;
                    multiple <<= 1;
                }

                absDividend -= tempDivisor;
                result += multiple;
            }

            // Apply the sign to the result
            result = negative ? -result : result;

            // Ensure the result is within the 32-bit integer range
            if (result > Int32.MaxValue)
            {
                return Int32.MaxValue;
            }

            if (result < Int32.MinValue)
            {
                return Int32.MinValue;
            }

            return (int)result;
        }

        public int Divide_Shamith(int dividend, int divisor)
        {
            int answer = 0;

            if (Int32.MinValue == dividend && divisor == -1) { return Int32.MaxValue; }

            int absDividend = Math.Abs(dividend);
            int absDivisor = Math.Abs(divisor);

            if (absDividend < absDivisor || divisor == 0)
            {
                return answer;
            }
            for (int i = 1; i <= absDividend; i++)
            {
                if (absDividend - (absDivisor * i) <= absDivisor)
                {
                    answer = ((divisor > 0 && dividend > 0) || (divisor < 0 && dividend < 0)) ? i : i * -1;
                    break;
                }
            }
            return answer;
        }
    }
}
