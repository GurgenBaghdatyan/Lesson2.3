using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //51
            bool b1 = false,t=false;
            double k;
            int x,a, b, c;
            double dd;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("k = ");
            k = Convert.ToDouble(Console.ReadLine());
            a = Convert.ToInt32(x / 100);
            b = Convert.ToInt32((x - a * 100) / 10);
            c = Convert.ToInt32(x - 10 * b - 100 * a);
            if (c == a + b) b1 = true;
            Console.WriteLine(Convert.ToString(b1));
            //52
            if (a == b || a == c||b==c) t= true;
            Console.WriteLine(Convert.ToString(t));
            //53
            if (x > k)
            {
                dd = x / (a + b + c);
                Console.WriteLine(dd);
            }
            else
            {
                dd = x / c;
                Console.WriteLine(dd);
            }
            //54
            if (a > b && a > c) Console.WriteLine(a);
            else if(b>c) Console.WriteLine(b);
            else Console.WriteLine(c);
            //55
            if (a < b && a < c) Console.WriteLine(a);
            else if (b < c) Console.WriteLine(b);
            else Console.WriteLine(c);
            //56
            if(c>b) Console.WriteLine((a+b+c)/x);
            else Console.WriteLine(x);
            //57
            if (x > 300) Console.WriteLine( b/c);
            else Console.WriteLine(a/c);
            //58
            char f;
            if (a + b > 5) f = 'a';
            else f = 'b';
            Console.WriteLine(f);
            //59
            int aa = a, bb = b, cc = c;
            if (bb > cc)
            {
                int temp = bb;
                bb = cc;
                cc = temp;
            }
            if (aa > bb)
            {
                int temp = bb;
                bb = aa;
                aa = temp;
            }
            if (bb > cc)
            {
                int temp = bb;
                bb = cc;
                cc = temp;
            }
            Console.WriteLine(aa + " " + bb + " " + cc);
            //60
            if(bb>aa)
            {
                int temp = bb;
                bb = aa;
                aa = temp;
            }
            if (cc > bb)
            {
                int temp = bb;
                bb = cc;
                cc = temp;
            }
            if (bb > aa)
            {
                int temp = bb;
                bb = aa;
                aa = temp;
            }
            Console.WriteLine(aa+" "+bb +" "+cc) ;










            Console.ReadKey();  
            
        }
    }
}
