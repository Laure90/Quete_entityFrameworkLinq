using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Species> speciesList = new List<Species>() {
                new Species() { Name = "white cougars", Population = 3},
                new Species() { Name = "white tigers", Population = 100},
                new Species() { Name = "albino turtles", Population = 15},
        };

            using (var context = new AnimalContext())
            {
                var whiteCougars = ;
                var whiteTigers = ;
                var albinoTurtles = ;
            }
        }
    }
}
