using System;
namespace codewars2
{
    /// <summary>
    /// Given Two integers a, b, find The sum of them, BUT You are not allowed to use the operators + and -
    /// The numbers(a, b) may be positive , negative values or zeros.
    /// Returning value will be an integer.
    /// </summary>
    public class Sum_of_Two_Integers
    {
        public static void Main(string[] args)
        {
            Console.Write(Add(27,6));
        }
        static int Add(int x, int y)
        {
            while (y != 0)
            {
                int carry = x & y;
                x ^= y;
                y = carry << 1;
            }
            return x;
        }
	static int Add_Recursive(int x, int y)
        {
            if(y==0) return x;
	    else return Add_Recursive(x^y, (x&y)<<1);
        }
    }
}
