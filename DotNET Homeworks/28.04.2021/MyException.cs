using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class MyException : Exception
    {
        public MyException() { }

        public MyException(string m)
            : base(m) { }

        public MyException(string m, Exception e)
            : base(m, e) { }
    }
}
