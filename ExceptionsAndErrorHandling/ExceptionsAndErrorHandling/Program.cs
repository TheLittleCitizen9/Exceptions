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
                RunLogic runLogic = new RunLogic();
                //runLogic.RunLogic1(null);
                //runLogic.RunLogic2("in.txt", "out.txt");
                //runLogic.RunLogic3("data");
                //runLogic.RunLogic4("abc", 9, 10);
                runLogic.RunLogic5("file");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
