using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmw b = new Bmw();
             Console.WriteLine(b.Start());
            Console.WriteLine(b.Klima());

            Mercedes m = new Mercedes();
                
            Console.WriteLine(m.Start());
            Console.WriteLine(m.Klima());

            Console.Read();
        }
    }
}
