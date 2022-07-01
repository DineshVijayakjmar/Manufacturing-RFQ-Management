//using RFQ_mgmt.Model;

//namespace RFQ_mgmt.Repository
//{
//    public class rfqRepo : IrfqRepo
//    {
//        private readonly Dbcontext _context;
//        public rfqRepo(Dbcontext context)
//        {
//            _context = context;

            
//        }

//        public async Task<List<Rfq>> Get(int Id)
//        {
//            var rec = await _context.RFQ.Where(x => x.Part_Id == Id).Select(x => new Rfq()
//            {
//                Rfq_id = x.Rfq_id,
//                Demand_id = x.Demand_id,
//                Part_Id = x.Part_Id,
//                Part_details = x.Part_details,
//                Quantity = x.Quantity,
//                Expected_supply_date = x.Expected_supply_date,
//                Specifications = x.Specifications
//            }).ToListAsync();

//            return rec;
//        }

//        public Task<Rfq> GetFeedback(int rId)
//        {
//            List<Rfq> rfq = _context.RFQ.ToList();
//            List<Supplier> supplier = _context.SUPPLIER.ToList();


//            {
                
//                var rfqViewModel = from s in supplier
//                                   join r in rfq on s.Part_id equals r.Part_Id
//                                   where r.Rfq_id == rId && s.Feedback > 7
//                                   select new { s.Part_id, r.Rfq_id, s.Supplier_Name, s.Feedback };
                

//                return (Task<Rfq>)rfqViewModel;
//            }
//        }
//    }
//}
