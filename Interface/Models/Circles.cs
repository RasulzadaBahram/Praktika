using Interface.Interface;

namespace Interface.Models
{
    class Circles : IShape
    {

        public int r;
        double pi=Math.PI;


        public double GetArea()
        {
            return r*r*pi / 2;
        }
    }
}
