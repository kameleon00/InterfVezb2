using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb2
{
    class SimpleClass : Icontrol, Isurface
    {
        void Icontrol.Print()
        {
            Console.WriteLine("Icontrol print");
        }
        void Isurface.Print()
        {
            Console.WriteLine("Isurface print");
        }
    }
}
