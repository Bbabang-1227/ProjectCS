using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Console;
using System.Collections;

using fs = FirstNamespace;
using ss = SecondNamespace;

namespace FirstNamespace
{
    class Test
    {
        public void f1()
        {
            WriteLine(1);
        }
    }
}

namespace SecondNamespace
{
    class Test
    {
        public void f1()
        {
            WriteLine(2);
        }
    }
}

namespace CS_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            fs.Test t1 = new fs.Test();
            t1.f1();

            ss.Test t2 = new ss.Test();
            t2.f1();
        }
    }
}
