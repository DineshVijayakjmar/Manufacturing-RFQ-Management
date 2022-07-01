using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantMicros.Models
{
    public class PlantReorderDetails
    {
        [ForeignKey("Part")]
        public int PartId { get; set; }
        [Key]
        public int PlantReorderId { get; set; }
        public string PartDetails { get; set; }
        public String ReorderStatus { get; set; }
        public DateTime ReorderDate { get; set; }
    }
}
