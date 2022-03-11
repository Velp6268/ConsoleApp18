using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor("TwinPower Turbo", 600, 261);
            Jet jet = new Jet("ТРД", 25000, 150000, 2008);
            Internalcombustion internalcombustion = new Internalcombustion("V8 AMG", 476, 209, 65);
            Diesel diesel = new Diesel("DHXA", 286, 215, 16);


            Console.WriteLine(motor.ToString());
            Console.WriteLine(jet.ToString());
            Console.WriteLine(internalcombustion.ToString());
            Console.WriteLine(diesel.ToString());

            Console.ReadKey();
        }
    }
}