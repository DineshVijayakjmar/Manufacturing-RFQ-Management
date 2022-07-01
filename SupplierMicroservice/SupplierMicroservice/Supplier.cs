using System.ComponentModel.DataAnnotations;

namespace SupplierMicroservice
{
    public class Supplier
    {
        public Supplier()
        {
            var SupplierPart = new HashSet<Supplier_Part>();
        }
        [Key]
        public int supplier_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
        public int feedback { get; set; }
    }
}
