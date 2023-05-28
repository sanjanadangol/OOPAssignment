using System;
namespace OOPS
{
    class Encapsulation
    {
        int x;
        public Encapsulation(int iX)
        {
            this.x = iX;
        }
        public void MySquare()
        {
            int Calc = x * x;
            Console.WriteLine(Calc);
        }
    }
}


