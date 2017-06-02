using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPCoreAngular.Models
{
    public class Breed
    {
        public int ID { get; set; } // Primary key.
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; } // Name of breed.
        
        public ICollection<Sheep> Sheep { get; set; } // Sheep belonging to breed.

        public Breed()
        {
            Sheep = new Collection<Sheep>();
        }
    }
}