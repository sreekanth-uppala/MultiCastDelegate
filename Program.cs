using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDeligate
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            A.D d1 = new A.D(b.m2);//singlecast delegate
            A.D d2 = new A.D(c.m3);//singlecast delegate
            A.D d3 = new A.D(c.m4);//single cast deligate
            //a.m1(d1);
            A.D d4 = d1 + d2 + d3;//Multicast deligate
            a.m1(d4);
            Console.ReadLine();
        }
    }
    public class A
    {
        public delegate void D(int x, int y);
        public void m1(D d)
        {
            d(10, 20);
        }
    }
    public class B
    {
        public void m2(int x,int y)
        {

            Console.WriteLine(x + y);
        }
    }
    public class C
    {
        public void m3(int x, int y)
        {

            Console.WriteLine(x - y);
        }
        public void m4(int x, int y)
        {

            Console.WriteLine(x * y);
        }
    }
}
