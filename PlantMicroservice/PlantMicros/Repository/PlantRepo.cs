using Microsoft.EntityFrameworkCore;
using PlantMicros.Data;
using PlantMicros.Models;

namespace PlantMicros.Repository
{
    public class PlantRepo : IPlantRepo
    {
        private readonly PlantDbContext _context;
        public PlantRepo(PlantDbContext context)
        {
            _context = context;
        }



        public async Task<List<PlantReorderDetails>> ViewPartsReOrder()
        {
            return await _context.PlantReoDetail.ToListAsync();
        }

        public async Task<Part> ViewStockInHand(int partId)
        {
            var stock = await _context.Parts.Where(x => x.PartId == partId).Select(x => new Part()
            {
                PartId = x.PartId,
                PartDescription = x.PartDescription,
                PartSpecification = x.PartSpecification,
                StockInHand = x.StockInHand
            }).FirstOrDefaultAsync();

            return (stock);
        }

        public async Task<string> UpdateMinMax(int min, int max, int Partid)
        {

            List<ReorderRules> reo = _context.ReoRule.ToList();
            List<Demand> dem = _context.Demands.ToList();
            {
                var rec = from r in reo
                          join d in dem on r.PartId equals d.PartId
                          where r.PartId == Partid
                          select d.DemandCount;

                if (min > (.3 * max) && min <= (.5 * max))
                {

                    if (max < 0.2 * rec.First())
                    {

                        return "Success Code";
                    }
                }
                return "Not successful";
            }
        }
    }
}
