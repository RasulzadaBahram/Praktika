using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Models
{
    class Rectangle : IShape
    {
        public int a;
        public int h;

        public double GetArea()
        {
            return a * h / 2;
        
        }

        
    }
}
