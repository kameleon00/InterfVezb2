using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb2
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass obj = new SimpleClass();
            //obj.Paint(); // Greška pri kompajliranju.
            Icontrol c = (Icontrol)obj;
            c.Print();

            Isurface s = (Isurface)obj;
            s.Print();

            Console.ReadLine();
        }
    }
}
