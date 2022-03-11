using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    internal class Motor
    {
        public Motor(string name, int capacity, double weigth)
        {
            Name = name;
            Capacity = capacity;
            Weigth = weigth;
        }

        public Motor() { }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public double Weigth { get; set; }

        public override string ToString()
        {
            return $"Группа - Двигатель\n" +
                $"Имя двигателя - {Name}\n" +
                $"Мощность - {Capacity}\n" +
                $"Масса - {Weigth} кг\n";
        }
    }
}