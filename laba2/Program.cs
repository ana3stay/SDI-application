using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exem[] arr = new Exem[10];

            string name = Console.ReadLine();
            double data = double.Parse(Console.ReadLine());
            string per = Console.ReadLine();
            double score = double.Parse(Console.ReadLine());
            Exem exem = new Wiwod(name, data, per, score);
            exem.Info();
            exem.setName();
            exem.Info();
            Wiwod wiwod = new Wiwod(name, data, per, score);
            wiwod.setScore();
            wiwod.Info();
        }
    }
}
