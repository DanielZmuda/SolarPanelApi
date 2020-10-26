using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Inverter
    {
     [Key]
        public int Id { get; set; }

       
        [Required]
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        [Required]
        public float MaximumPower { get; set; }

     
    }
}
