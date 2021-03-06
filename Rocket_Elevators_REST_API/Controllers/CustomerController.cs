using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rocket_Elevators_REST_API.Models;

namespace Rocket_Elevators_REST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly armanadibiContext _context;
        public CustomerController(armanadibiContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Produces("application/json")]
        [HttpGet("{email}")]
        public async Task<IActionResult> GetSpect(string email)
        {
            try
            {
               if(_context.Customers.Any(o=> o.ContactEmail == email)) {
                    return Ok("Found");
                }
                else
                {
                    return Ok("Not Found");
                }
                    
              

            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpGet("id/{email}")]
        public async Task<IActionResult> GetId(string email)
        {
            try
            {
                if (_context.Customers.Any(o => o.ContactEmail == email))
                {

                    var customer = _context.Customers.Where(o => o.ContactEmail == email).FirstOrDefault();

                    return Ok(customer.Id);
                }
                else
                {
                    return Ok("Not Found");
                }



            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
