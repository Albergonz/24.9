using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._9
{
    internal class Vector
    {
        public double Xv { get; set; }
        public double Yv { get; set; }


        public Vector(double x, double y)
        { 
        Xv = x;
        Yv = y;
        }

        public Vector()
        {
        }

        public Vector Somma(Vector Ve)
        {
            Vector Vr = new Vector();
            Vr.Xv = Ve.Xv + Xv;
            Vr.Yv = Ve.Yv + Yv;
            return Vr;
        }
            
        }
    }

