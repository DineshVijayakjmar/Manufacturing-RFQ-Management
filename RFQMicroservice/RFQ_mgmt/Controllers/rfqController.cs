using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFQ_mgmt.DBContext;
using RFQ_mgmt.Model;
using System.Web.Http.Cors;
//using RFQ_mgmt.Repository;

namespace RFQ_mgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class rfqController : ControllerBase
    {
        private readonly Dbcontext _context;
        //private IrfqRepo _repo;

        public rfqController(Dbcontext context)
        {
            _context = context;
            //_repo = repo;
        }

        [HttpGet("GetRFQ")]
        public async Task<ActionResult<List<Rfq>>> Get()
        {
            List<Rfq> lrfq = _context.RFQ.ToList();
            var query = from r in lrfq
                        select new { r.rfqId, r.partName, r.demandid, r.Specification, r.Quantity, r.timetoSupply };
            return Ok(query);
        }



        [HttpGet("Id")]
       // public async Task<IActionResult> Get(int Id)
            public async Task<ActionResult<Rfq>> Get(int Id)
        {
            //var x = await _repo.Get(Id);
            //return Ok(x);
            
            var rec = await _context.RFQ.Where(x => x.Part_Id == Id).Select(x => new Rfq()
            {
                rfqId = x.rfqId,
                partName = x.partName,
                demandid = x.demandid,

                Specification = x.Specification,
                //Part_Id =x.Part_Id,
                Quantity = x.Quantity,
                timetoSupply = x.timetoSupply
            }).ToListAsync();

            return Ok(rec);
        }
        [HttpGet("rId")]
        //public async Task<IActionResult> GetFeedback(int rId) {
            public async Task<ActionResult<Supplier>> GetFeedback(int rId)
            {
            //    var y = await _repo.GetFeedback(rId);
            //return Ok(y);

             List<Rfq> rfq = _context.RFQ.ToList();
             List<Supplier> supplier = _context.SUPPLIER.ToList();


             {
                 //insertDummyData();
                 var rfqViewModel = from s in supplier
                                     join r in rfq on s.Part_id equals r.Part_Id
                                     where r.rfqId == rId && s.Feedback >7 
                                     select new { s.Part_id,r.rfqId, s.Supplier_Name,s.Feedback };
                 //var newtable= new Fbjoin { FeedbackList = (IEnumerable<Feedback>)rfqViewModel };

                 return Ok(rfqViewModel);
             }
        }

           
        }
    }

