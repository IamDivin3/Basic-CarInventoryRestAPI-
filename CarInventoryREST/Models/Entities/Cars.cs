using System.ComponentModel.DataAnnotations;

namespace CarInventoryREST.Models.Entities
{
    public class Cars
    {
       
        [Key] public Guid CarId { get; set; }
        public string ModelId { get; set; } = string.Empty; 

        public string YearId { get; set; } = string.Empty;  

        public string Color { get; set; } = string.Empty;   

        public string EngineId { get; set; } = string.Empty;
    }
}
