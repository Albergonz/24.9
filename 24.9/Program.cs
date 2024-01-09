using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector V1 = new Vector(2,2);
            Vector V2 = new Vector(3,3);
            Vector V3 = new Vector(4,4); //parse?
                      
            Vector Vr = V1.Somma(V2); ;
            Console.WriteLine("\n Vr tra 1 e 2: {0}, {1}", Vr.Xv, Vr.Yv);

            Vector Vr2 = V1.Somma(V3); ;
            Console.WriteLine("\n Vr tra 1 e 3: {0}, {1}", Vr2.Xv, Vr2.Yv);

            Vector Vr3 = V3.Somma(V2).Somma(V1); ;
            Console.WriteLine("\n Vr tra 3 e 2: {0}, {1}", Vr3.Xv, Vr3.Yv);
            Console.ReadLine(); 

        }
    }
}
