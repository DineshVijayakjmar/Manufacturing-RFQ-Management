using System.ComponentModel.DataAnnotations;

namespace PlantMicros.Models
{
    public class Part
    {
        [Key]
        public int PartId { get; set; }
        public string PartDescription { get; set; }
        public string PartSpecification { get; set; }
        public int StockInHand { get; set; }
    }
}
