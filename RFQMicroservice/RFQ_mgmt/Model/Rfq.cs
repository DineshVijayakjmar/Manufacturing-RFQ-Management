using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RFQ_mgmt.Model

{
    public class Rfq
    {
        [Key]
        public int rfqId { get; set; }
        public int demandid { get; set; }

        [ForeignKey("Part_id")]
        public int Part_Id { get; set; }
        public string partName { get; set; }
        public string Quantity { get; set; }
        public DateTime timetoSupply { get; set; }
        public string Specification { get; set; }

        public static implicit operator Rfq(List<Rfq> v)
        {
            throw new NotImplementedException();
        }
    }
}
