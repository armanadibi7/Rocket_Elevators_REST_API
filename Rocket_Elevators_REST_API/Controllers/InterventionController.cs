using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rocket_Elevators_REST_API.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rocket_Elevators_REST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterventionController : Controller
    {
        // GET: /<controller>/
        private readonly armanadibiContext _context;
        public InterventionController(armanadibiContext context)
        {
            _context = context;
        }

        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> GetPending()
        {
            try
            {
                var pending_intervention = _context.Interventions.Where(b => b.Status == "Pending");

                return Ok(pending_intervention);
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpPost]
        public async Task<IActionResult> PostStatus(Intervention input)
        {
            try
            {
                var change_status = _context.Interventions.Where(b => b.Id == input.Id).FirstOrDefault();
                var current_status = change_status.Status;
                change_status.Status = input.Status;
                change_status.InterventionStart = DateTime.Now;
                _context.SaveChanges();
                return Ok("Status has been successfully changed");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
