using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsAndErrorHandling
{
    public class ScubaException : Exception
    {
        const string MESSAGE = "This is a Scuba Exception";
        private int _studentNumber;
        public ScubaException(int studentNumber):base(MESSAGE)
        {
            _studentNumber = studentNumber;


        }
    }
}
