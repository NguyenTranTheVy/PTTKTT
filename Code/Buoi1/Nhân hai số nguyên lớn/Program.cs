using System;
using System.Numerics;

namespace Nhân_hai_số_nguyên_lớn
{
    class Program
    {
        static void Main()
        {
            string num1 = "123456789123456789";
            string num2 = "987654321987654321";

            BigInteger bigNum1 = BigInteger.Parse(num1);
            BigInteger bigNum2 = BigInteger.Parse(num2);

            BigInteger result = bigNum1 * bigNum2;

            Console.WriteLine("Kết quả của phép nhân là:");
            Console.WriteLine(result);
        }
    }

}