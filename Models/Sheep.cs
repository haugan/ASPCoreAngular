namespace ASPCoreAngular.Models
{
    public class Sheep
    {
        public int ID { get; set; } // Primary key.
        public int BreedID { get; set; } // Foreign key.
        
        public int Number { get; set; } // Individnummer. 
        public Breed Breed { get; set; } // Breed of sheep.
    }
}