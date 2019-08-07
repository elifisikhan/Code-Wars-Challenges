using System;
using System.Linq;
namespace codewars2
{
    /// <summary>
    /// Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. 
    /// You can guarantee that input is non-negative.
    /// Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
    /// </summary>
    public class BitCounting
    {
        public static int CountBits_(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
        public static int CountBits(int n)
        {
            int k = 1, toplam = 0, i = 0, temp = n;
            while (temp != 0)
            {
                temp = temp / 2; k++;
            }

            int[] dizi = new int[k];
            while (n / 2 != 0)
            {
                if (n % 2 == 1)
                {
                    n /= 2; dizi[i] = 1; i =+ 1;
                }
                else
                {
                    n /= 2; dizi[i] = 0; i ++;
                }
                dizi[i] = 1;
            }
            for (int j = 0; j < dizi.Length; j++)
                toplam = toplam + dizi[j];
            return toplam;
        }
    }
}
