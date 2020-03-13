//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using project.Models;

//namespace project.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrderdetailsController : ControllerBase
//    {
//        private readonly AppDbContext _context;

//        public OrderdetailsController(AppDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Orderdetails
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Orderdetails>>> GetOrderDetails()
//        {
//            return await _context.OrderDetails.ToListAsync();
//        }

//        // GET: api/Orderdetails/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Orderdetails>> GetOrderdetails(int id)
//        {
//            var orderdetails = await _context.OrderDetails.FindAsync(id);
//            orderdetails.order = _context.Orders.Where(c => c.OrderDetailsId == id).ToList();


//            if (orderdetails == null)
//            {
//                return NotFound();
//            }

//            return orderdetails;
//        }

//        // PUT: api/Orderdetails/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://aka.ms/RazorPagesCRUD.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutOrderdetails(int id, Orderdetails orderdetails)
//        {
//            if (id != orderdetails.OrderDetailId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(orderdetails).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!OrderdetailsExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Orderdetails
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see https://aka.ms/RazorPagesCRUD.
//        [HttpPost]
//        public async Task<ActionResult<Orderdetails>> PostOrderdetails(Orderdetails orderdetails)
//        {
//            _context.OrderDetails.Add(orderdetails);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetOrderdetails", new { id = orderdetails.OrderDetailId }, orderdetails);
//        }

//        // DELETE: api/Orderdetails/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<Orderdetails>> DeleteOrderdetails(int id)
//        {
//            var orderdetails = await _context.OrderDetails.FindAsync(id);
//            if (orderdetails == null)
//            {
//                return NotFound();
//            }

//            _context.OrderDetails.Remove(orderdetails);
//            await _context.SaveChangesAsync();

//            return orderdetails;
//        }

//        private bool OrderdetailsExists(int id)
//        {
//            return _context.OrderDetails.Any(e => e.OrderDetailId == id);
//        }
//    }
//}
