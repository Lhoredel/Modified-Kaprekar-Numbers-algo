using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
       List<long> kaprekarNums = new List<long>();
       
       for (long num = p; num <= q; num++)
       {
        if (IsKaprekarNumber(num))
        {
            kaprekarNums.Add(num);
        }
        }
        
        if (kaprekarNums.Count == 0)
        {
        Console.WriteLine("INVALID RANGE");
        }
        else
        {
        Console.WriteLine(string.Join(" ", kaprekarNums));
        }
}
private static bool IsKaprekarNumber(long num)
{
    if (num == 1)
    return true;
    
    long square = num * num;
    string squareStr = square.ToString();
    int len = squareStr.Length;
    
    for (int splitPos = 1; splitPos < len; splitPos++)
    {
        string leftStr = squareStr.Substring(0, splitPos);
        string rightStr = squareStr.Substring(splitPos);
        
        if (rightStr.All(c => c == '0'))
        continue;
        
        long left = long.Parse(leftStr);
        long right = long.Parse(rightStr);
        
        if (left + right == num && right > 0)
        {
            return true;
        }
    }
    
    return false;
}
    }

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
