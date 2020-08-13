using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionsAndErrorHandling
{
    public class RunLogic : Logic
    {
        private Logic _logic;
        public RunLogic()
        {
            _logic = new Logic();
        }
        public int RunLogic1(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ScubaException(9);
            }
            else
            {
                return _logic.Logic1(numbers);
            }
        }

        public void RunLogic2(string inputFileName, string outputFileName)
        {
            try
            {
                _logic.Logic2(inputFileName, outputFileName);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public int RunLogic3(string data)
        {
            int result;
            if(!Int32.TryParse(data, out result))
            {
                throw new ScubaException(9);
            }
            else
            {
                return Int32.Parse(data);
            }
        }

        public void RunLogic4(string data1, int data2, long data3)
        {
            try
            {
                _logic.Logic4(data1, data2, data3);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public void RunLogic5(string dllName)
        {
            try
            {
                _logic.Logic5(dllName);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
