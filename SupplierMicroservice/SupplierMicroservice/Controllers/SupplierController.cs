using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplierMicroservice.Repository;
using System.Web.Http.Cors;

namespace SupplierMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [EnableCors(origins: "*", headers: "*", methods: "*")]


public class SupplierController : ControllerBase
    {
        private readonly MyContext _context;
        //private ISupplierRepo _con;

        public SupplierController(MyContext myContext)
        {
            _context = myContext;
        }
        //public SupplierController(ISupplierRepo repo)
        //{
        //    _con = repo;
        //}

        //[HttpGet("GetAllSuppliers")]
        //public async Task<ActionResult<List<Supplier>>> GetAllSuppliers()
        //{
        //    //List<Supplier> lsupplier = _context.Suppliers.ToList();
        //    //List<Supplier_Part> lsupplier_part = _context.Supplier_Parts.ToList();
        //    //var query = from s in lsupplier
        //    //            join sp in lsupplier_part on s.supplier_id equals sp.sid
        //    //            select new { getsupplier = s /*, getsupplier_part = sp*/ };
        //    //return Ok(query);
        //    //return Ok(await _context.Suppliers.ToListAsync());
        //    //var pl = await _con.GetAllSuppliers();
        //    //return Ok(pl);
        //}
        [HttpGet("GetAllSuppliers")]
        public async Task<ActionResult<List<Supplier>>> Get()
        {
            return Ok(await _context.Suppliers.ToListAsync());
        }

        [HttpGet("GetSupplierOfPart")]
        public async Task<ActionResult<List<Supplier>>> GetSupplierOfPart(int id)
        {

            List<Supplier> lsupplier = _context.Suppliers.ToList();
            List<Supplier_Part> lsupplier_part = _context.Supplier_Parts.ToList();
            var query = from s in lsupplier
                        join sp in lsupplier_part on s.supplier_id equals sp.sid
                        where sp.partid == id
                        //select new { s.supplier_id, s.name, s.location, sp.quantity, sp.timeperiod };
                        select new { s.supplier_id, s.name, s.location, s.email, s.phone, s.feedback };
            return Ok(query);
            //var pl = await _con.GetSupplierOfPart(id);
            //return Ok(pl);
        }

        [HttpPost("addSupplier")]
        public async Task<ActionResult<List<Supplier>>> AddSupplier(Supplier sup)
        {
            _context.Suppliers.Add(sup);
            await _context.SaveChangesAsync();

            return Ok(await _context.Suppliers.ToListAsync());
            //var pl = await _con.AddSupplier(sup);
            //return Ok(pl);
        }

        [HttpPut("Update")]
        public async Task<ActionResult<List<Supplier>>> UpdateSupplier(Supplier request)
        {
            var dbSup = await _context.Suppliers.FindAsync(request.supplier_id);
            if (dbSup == null)
                return BadRequest("Hero not found.");

            dbSup.name = request.name;
            dbSup.email = request.email;
            dbSup.phone = request.phone;
            dbSup.location = request.location;
            dbSup.feedback = request.feedback;
            

            await _context.SaveChangesAsync();

            return Ok(await _context.Suppliers.ToListAsync());
            //var pl = await _con.UpdateSupplier(request);
            //return Ok(pl);
        }

        [HttpPut("UpdateFeedback")]
        public async Task<ActionResult<List<Supplier>>> UpdateFeedback(Supplier request)
        {
            var dbSup = await _context.Suppliers.FindAsync(request.supplier_id);
            if (dbSup == null)
                return BadRequest("not found.");

            dbSup.feedback = request.feedback;

            await _context.SaveChangesAsync();

            return Ok(await _context.Suppliers.ToListAsync());
            //var pl = await _con.UpdateFeedback(request);
            //return Ok(pl);
        }
    }
}