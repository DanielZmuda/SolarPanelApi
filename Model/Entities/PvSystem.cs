using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entities
{
    public class PvSystem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("PvPanelId")]
        public PvPanel PvPanel { get; set; }

        [ForeignKey("InverterId")]
        public Inverter Inverter { get; set; }
        [Required]
        public int NumberOfPvPanels { get; set; }
        [Required]
        public float MountingAngle { get; set; }
        [Required]
        public string MountingDirection { get; set; }

        public int PvPanelId { get; set; }

        public int InverterId { get; set; }


    }
}
