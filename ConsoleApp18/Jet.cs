using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    internal class Jet : Motor
    {
        public Jet(string name, int capacity, double weight, int motoryear) : base(name, capacity, weight)
        {
            MotorYear = motoryear;
        }

        public Jet() { }

        public int MotorYear { get; set; }

        public override string ToString()
        {
            return $"Группа - Реактивного двигателя\n" +
                $"Имя двигателя - {Name}\n" +
                $"Мощность - {Capacity}\n" +
                $"Вес - {Weigth} кг\n" +
                $"Год двигателя - {MotorYear} г.\n";
        }
    }
}