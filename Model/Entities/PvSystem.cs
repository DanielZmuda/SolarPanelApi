using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entities
{
    public class PvSystem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public PvPanel PvPanel { get; set; }

        public Inverter Inverter { get; set; }
        [Required]
        public int NumberOfPvPanels { get; set; }
        [Required]
        public float MountingAngle { get; set; }
        [Required]
        public string MountingDirection { get; set; }
    }
}
