using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException()
        {

        }

        public EmployeeNotFoundException(String message) : base(message)
        {
        }

        public EmployeeNotFoundException(String message, Exception innerEx) : base(message, innerEx)
        {

        }
    }
    class CustomExceptions
    {
        static void Main2(string[] args)
        {
            try
            {
                throw new EmployeeNotFoundException("LOL you're not in our DB!");
            } catch (EmployeeNotFoundException empX)
            {
                Console.WriteLine(empX.Message);
            }
        }
    }
}
