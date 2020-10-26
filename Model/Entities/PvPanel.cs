using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class PvPanel
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name{ get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        [Required]
        public double Power { get; set; }
        [Required]
        public float PanelLength { get; set; }
        [Required]
        public float PanelWidth { get; set; }

    }
}
