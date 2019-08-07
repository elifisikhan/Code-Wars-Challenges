using System;
namespace codewars2
{
    /// <summary>
    /// Disarium number is the number that The sum of its digits powered with their respective positions is equal to the number itself.
    /// </summary>
    class Discardium_
    {
        public static void Main(string[] args)
        {
            Console.Write(Discardium(564));
        }
        public static string Discardium(int sayi)
        {
            int N = sayi, len = Convert.ToString(N).Length, toplam = 0;
            int[] basamak = new int[len];
            for (int i =0; i<len; i++)
            {
                basamak[i] =  N / Convert.ToInt32(Math.Pow(10,len -1-i));
                N %= Convert.ToInt32(Math.Pow(10, len-1-i));
            }
            for(int i=0; i<len; i++)
            {
                toplam =+ Convert.ToInt32(Math.Pow(basamak[i],i+1));
            }
            if (toplam == sayi)
                return "Disarium !!";
            else
                return "Not !!";
        }
    }
}
