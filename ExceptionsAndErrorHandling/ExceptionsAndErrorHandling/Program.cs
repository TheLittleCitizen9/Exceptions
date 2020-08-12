using System;

namespace ExceptionsAndErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;

            try
            {
                throw new ScubaException(number);
            }
            catch (ScubaException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
