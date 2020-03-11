using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Species
    {
        public Guid SpeciesID { get; set; }
        public String Name { get; set; }
        public int Population { get; set; }
        public Animal Animal { get; set; }
    }
}
