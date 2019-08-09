using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
[TestFixture]
public class Tests
{
    [TestCase(21, ExpectedResult = 12)]
    [TestCase(907, ExpectedResult = 790)]
    [TestCase(531, ExpectedResult = 513)]
    [TestCase(1027, ExpectedResult = -1)]
    [TestCase(441, ExpectedResult = 414)]
    [TestCase(123456798, ExpectedResult = 123456789)]
    public long FixedTests(long n)
    {
        return Kata.NextSmaller(n);
    }
}
public class Kata
{
    static List<long> perList;
    public static void Degistir(ref char a, ref char b)
    {
        if (a == b) return;
        char c = a;
        a = b;
        b = c;
    }
    public static void Permutasyon(char[] dizi, long sol, long sag)
    {
        if (sol == sag)
        {
            string s = new string(dizi);
            char[] metin_ = s.ToCharArray();
            if (metin_[0] != '0')
            {
                perList.Add(Convert.ToInt64(s));
            }
        }

        else
            for (long i = sol; i <= sag; i++)
            {
                Degistir(ref dizi[sol], ref dizi[i]);
                Permutasyon(dizi, sol + 1, sag);
                Degistir(ref dizi[sol], ref dizi[i]);
            }
    }
    public static long NextSmaller(long sayi_)
    {
        perList = new List<long>();
        string sayi = Convert.ToString(sayi_);
        char[] metin = sayi.ToCharArray();
        Permutasyon(metin, 0, metin.Length - 1);

        #region  bir küçüðünün bulunmasý
        long sayi1 = Convert.ToInt64(sayi);
        perList.Sort((a, b) => -1 * a.CompareTo(b));
        long result = -1;
        foreach (var item in perList)
        {

            if (item < sayi1)
            {
                result = item;

                break;
            }
        }
        #endregion
        long result_ = Convert.ToInt64(result);
        return result_;
    }
}