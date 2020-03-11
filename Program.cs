using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AnimalContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var speciesCougar = new Species
                {
                    Name = "cougars",
                    Population = 3
                };
                var speciesTiger = new Species
                {
                    Name = "tigers",
                    Population = 100
                };
                var speciesTurtle = new Species
                {
                    Name = "turtles",
                    Population = 15
                };      

                var animal1 = new Animal
                {
                    Name = "White Cougar",
                    Species= speciesCougar
                };

                var animal2 = new Animal
                {
                    Name = "White Tiger",
                    Species = speciesTiger
                };

                var animal3 = new Animal
                {
                    Name = "Albinos Turtle",
                    Species = speciesTurtle
                };
                List<Species> SpeciesList = new List<Species> { speciesCougar, speciesTiger, speciesTurtle};
                List<Animal> AnimalList = new List<Animal> { animal1, animal2, animal3 };

                context.AddRange(SpeciesList);
                context.AddRange(AnimalList);
                context.SaveChanges();

                //foreach(var animal in context.Species)
                //{

                //}

                var whiteCougars = from spec in context.Species
                                   where spec.Name == "cougars"
                                   select new { spec.Name, spec.Population };

                var whiteTigers = from spec in context.Species
                                  where spec.Name == "tigers"
                                  select new { spec.Name, spec.Population };

                var albinosTurtle = from spec in context.Species
                                   where spec.Name == "turtles"
                                   select new { spec.Name, spec.Population };
            }
        }
    }
}
