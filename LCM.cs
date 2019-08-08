using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ConsoleApp4
{
    /// <summary>
    /// Write a function that calculates the least common multiple of its arguments; each argument is assumed to be a non-negative integer.
    /// In the case that there are no arguments (or the provided array in compiled languages is empty), return 1.
    /// </summary>
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.That(Kata.Lcm(new List<int> { 2, 5 }), Is.EqualTo(10));
            Assert.That(Kata.Lcm(new List<int> { 2, 3, 4 }), Is.EqualTo(12));
            Assert.That(Kata.Lcm(new List<int> { 9 }), Is.EqualTo(9));
        }
    }
    public static class Kata
    {
        public static int Lcm(List<int> nums)
        {
            if (nums.Count == 1) return nums[0];
            int sayi = 0;
            for (int i = 1;; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
		    if(nums[j]==0) return 0;
                    if (i % nums[j] == 0)sayi++;
                }
                if (sayi == nums.Count) return i;
                else sayi = 0;
            }
            return 1;
        }
    }
}
