using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal abstract class Exem
    {
        private string _name;
        private double _data;
        private string _per;
        private List<string> _score;
       

        protected Exem() { }

        protected Exem(string name, double data, string per)
        {
            _name = name;
            _data = data;
            _per = per;
        }

        public virtual void setName()
        {
            _name = Console.ReadLine();
            Console.WriteLine($"Присвоено имя{_name}");
        }

        public virtual void Info()
        {
            Console.WriteLine($"ФИО: {_name}\n" +
                $"Дата: {_data}\n" +
                $"Вопросы: {_per}");
        }

    }
}
