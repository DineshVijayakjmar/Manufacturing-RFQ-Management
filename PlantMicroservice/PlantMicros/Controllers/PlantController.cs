using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantMicros.Data;
using PlantMicros.Models;
using PlantMicros.Repository;
using System.Web.Http.Cors;

namespace PlantMicros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PlantController : ControllerBase
    {
        private readonly PlantDbContext _context;

        public PlantController(PlantDbContext context)
        {
            _context = context;
        }
        //private IPlantRepo _repo;

        //public PlantController(IPlantRepo repo)
        //{
        //    _repo = repo;
        //}

        //getpartdetails 
        [HttpGet("get")]
        // public async Task<ActionResult<List<PlantReorderDetails>>> ViewPartsReOrder()
        public async Task<ActionResult<List<PlantReorderDetails>>> ViewPartsReOrder()
        {

            return Ok(await _context.PlantReoDetail.ToListAsync());
            //var pl = await _repo.ViewPartsReOrder();
            //return Ok(pl);
        }

        //New Get api
        [HttpGet("getReorder")]
        // public async Task<ActionResult<List<PlantReorderDetails>>> ViewPartsReOrder()
        public async Task<ActionResult<List<PlantReorderDetails>>> ViewReOrderDetails()
        {

            return Ok(await _context.Parts.ToListAsync());
            //var pl = await _repo.ViewPartsReOrder();
            //return Ok(pl);
        }

        //getstockinhandbyid
        [HttpGet("{PartId}")]
        //public async Task<ActionResult<Part>> ViewStockInHand(int Id)
        public async Task<ActionResult<Part>> ViewStockInHand(int PartId)
        {
            var stock = await _context.Parts.Where(x => x.PartId == PartId).Select(x => new Part()
            {
                PartId = x.PartId,
                PartDescription = x.PartDescription,
                PartSpecification = x.PartSpecification,
                StockInHand = x.StockInHand
            }).FirstOrDefaultAsync();
            if (stock == null)
                return BadRequest("Part Id not found.");
            return Ok(stock);
            //var pl1 = await _repo.ViewStockInHand(PartId);
            //return Ok(pl1);

        }


        //[HttpPut("Putminmax")]
        ////public async Task<ActionResult<ReorderRules>> UpdateMinMax(int min, int max, int id)
        //public async Task<ActionResult<string>> UpdateMinMax(int min, int max, int id) 
        //{
        //    //var pl2 = await _repo.UpdateMinMax(min, max, id);
        //    //return Ok();
        //    List<ReorderRules> reo = _context.ReoRule.ToList();
        //    List<Demand> dem = _context.Demands.ToList();
        //    {
        //        var rec = from r in reo
        //                  join d in dem on r.PartId equals d.PartId
        //                  where r.PartId == id
        //                  select d.DemandCount;

        //        if (min > (.3 * max) && min <= (.5 * max))
        //        {

        //            if (max < 0.2 * rec.First())
        //            {
        //                //rec.MinQuantity = min;
        //                return Ok("Updated");
        //            }
        //        }
        //        return BadRequest();
        //    }
        //}

        [HttpPut("Putminmax")]
        //public async Task<ActionResult<ReorderRules>> UpdateMinMax(int min, int max, int id)
        public async Task<ActionResult<List<ReorderRules>>> UpdateMinMax(updateobj request)
        {
            //var pl2 = await _repo.UpdateMinMax(min, max, id);
            //return Ok();
            List<ReorderRules> reo = _context.ReoRule.ToList();
            List<Demand> dem = _context.Demands.ToList();
            {
                var rec = from r in reo
                          join d in dem on r.PartId equals d.PartId
                          where r.PartId == request.id
                          select d.DemandCount;

                if (request.min > (.3 * request.max) && request.min <= (.5 * request.max))
                {

                    if (request.max < 0.2 * rec.First())
                    {
                        //rec.MinQuantity = min;
                        var dbSup = await _context.ReoRule.FindAsync(request.id);
                        if (dbSup == null)
                            return BadRequest("not found.");
                        //return Ok("Updated");
                        dbSup.MinQuantity = request.min;
                        dbSup.MaxQuantity = request.max;

                        await _context.SaveChangesAsync();
                        return Ok(await _context.ReoRule.ToListAsync());
                    }
                }
                return BadRequest();
            }
        }

    }


}