using System.Numerics;

namespace FactorialLinq
{
    // I use BigInteger, because if you take the factorial of a large number, there will not be enough values ​​in int32
    public class FactorialFind
    {
        public static BigInteger Find(int range)
        {
           var numbers = Enumerable.Range(1, range);
           return numbers.Aggregate(BigInteger.One, (a, b) => a * b);
     
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}