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
    public class AndroidAppController : Controller
    {
       
      
            private readonly armanadibiContext _context;
            public AndroidAppController(armanadibiContext context)
            {
                _context = context;
            }



            [Produces("application/json")]
            [HttpGet("verifyuser/{email}")]
            public async Task<IActionResult> FindAll(string email)
            {
                try
                {
                    if (_context.Employees.Any(o => o.Email == email))
                    {
                        return Ok("Success");
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
