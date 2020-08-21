using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Model;

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
