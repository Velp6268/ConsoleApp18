using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    internal class Internalcombustion : Motor
    {
        public Internalcombustion(string name, int capacity, double weigth, int temperature) : base(name, capacity, weigth)
        {
            Temperature = temperature;
        }

        public Internalcombustion() { }

        public int Temperature { get; set; }

        public override string ToString()
        {
            return $"Группа - Двигатель внутреннего сгорания\n" +
                $"Имя двигателя - {Name}\n" +
                $"Мощность - {Capacity}\n" +
                $"Вес - {Weigth} кг\n" +
                $"Температура двигателя - {Temperature} C\n";
        }
    }
}