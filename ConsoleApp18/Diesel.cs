using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    internal class Diesel : Motor
    {
        public Diesel(string name, int capacity, double weigth, int fuelconsumption) : base(name, capacity, weigth)
        {
            FuelConsumption = fuelconsumption;
        }

        public Diesel() { }

        public int FuelConsumption { get; set; }

        public override string ToString()
        {
            return $"Группа - Дизельный двигатель\n" +
                $"Имя двигателя - {Name}\n" +
                $"Мощность - {Capacity}\n" +
                $"Вес - {Weigth} кг\n" +
                $"Расход топливо - {FuelConsumption} литров\n";
        }
    }
}