using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ASPCoreAngular.Controllers.Resources
{
    public class BreedResource
    {
        public int ID { get; set; } // Primary key.
        public string Name { get; set; } // Name of breed.
        public ICollection<SheepResource> Sheep { get; set; } // Sheep belonging to breed.

        public BreedResource()
        {
            Sheep = new Collection<SheepResource>();
        }
    }
}