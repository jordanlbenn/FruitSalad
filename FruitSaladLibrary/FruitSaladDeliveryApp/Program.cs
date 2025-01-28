using FruitSaladLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSaladDeliveryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strawberry sweetStrawberry = new Strawberry("Bright Red", 15.0, true, true, 9);
            Strawberry sourStrawberry = new Strawberry("Light Red", 10.0, false, false, 4);
            // creating a Fruit Salad
            var salad = new FruitSalad(new List<Fruit> { sweetStrawberry, sourStrawberry }, 3);
            // Testing ToString
            Console.WriteLine(salad.ToString());
            // Test seving
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve()); // should exceed servings
            Console.Write(salad.ToString());

        }
    }
}
