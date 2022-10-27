using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal class Wiwod : Exem, Interface1 //член видим только в пределах текущей единицы компиляции
    {

        private double _score { get; set; }

        public Wiwod(string name, double data, string per, double score) : base(name, data, per)
        {
            _score = score;

        }
        public override void setName()
        {
            base.setName();
            Console.WriteLine("переопределённый метод");
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Оценка: {_score}");
        }

        public void setScore()
        {
            _score = Convert.ToInt32(Console.ReadLine());
        }
    }
}
