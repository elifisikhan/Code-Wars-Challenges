using System;

namespace ConsoleApp3
{
    /// <summary>
    /// The radical of n, rad(n), is the product of the distinct prime factors of n. For example, 504 = 23 × 32 × 7, so rad(504) = 2 × 3 × 7 = 42.
    /// </summary>
    public class Ordered__Radicals
    {
        public static void Main(string[] args)
        {
            Rad();
        }
        static int Rad()
        {
            for (int k = 1, num=1 ; k <= 10000; k++, num++) {
                int tnum_ = num, rad=1;
                int[] asal = new int[10000];

                while (tnum_ % 2 == 0)
                {
                    tnum_ /= 2; asal[2]++;
                }
                for (int i = 3, j = 3; j < 10000; i++, j++)
                {
                    if (tnum_ > 0)
                    {
                        while (tnum_ % i == 0)
                        {
                            tnum_ = tnum_ / i;      
                            asal[j]++;
                        }
                    }
                }
                for (int i = 2; i < 10000; i++)
                {
                    if (asal[i] != 0)
                    {
                        rad= rad * i;
                    }
                }
                Console.WriteLine(" Rad( " + num + " ) = " + rad+"\n");
            }
            return 1;
        }
    }
}
