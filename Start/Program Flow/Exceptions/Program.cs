using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 0;
            int result;

            try {
                result = x / y;
            } catch (DivideByZeroException e){
                Console.WriteLine(e.Message);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("x has to be 1000 or less");
            } finally {
                Console.WriteLine("this always runs");
            }
            Console.WriteLine("The result is: {0}", result);
        }
    }
}
