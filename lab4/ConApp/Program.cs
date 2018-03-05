using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipse ellipse = new Ellipse(10, 10, 50, 15);
            var str = ellipse.JSONSerialize();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
