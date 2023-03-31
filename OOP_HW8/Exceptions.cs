using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW8
{
    public class InvalidPersonException : Exception
    {
        public InvalidPersonException(string message) : base(message)
        { 
        }
    }

    public class InvalidCoursesException : Exception
    {
        public InvalidCoursesException(string message) : base(message)
        {
        }
    }
}
