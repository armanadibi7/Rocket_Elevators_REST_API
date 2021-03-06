using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Rocket_Elevators_REST_API.Models;

namespace Rocket_Elevators_REST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly armanadibiContext _context;

        public ProductController(armanadibiContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Produces("application/json")]
        [HttpGet("{email}")]
        private async Task<List<Building>> getBuilding(long id)
        {
            var buildings = _context.Buildings.Where(b => b.CustomerId == id).Include(b => b.Batteries).ThenInclude(c => c.Columns).ThenInclude(e => e.Elevators).ToList();
            List<Building> buildingsList = new List<Building>();
            foreach (var b in buildings)
            {
                buildingsList.Add(b);
            }
            return buildingsList;
        }
        [Produces("application/json")]
        [HttpGet("building/{id}")]
        public async Task<List<Building>> GetSpect(int id)
        {
            try
            {
                var buildings =  _context.Buildings.Where(b => b.CustomerId == id).Include(b => b.Batteries).ThenInclude(c => c.Columns).ThenInclude(e => e.Elevators).ToList();
                List<Building> buildingsList = new List<Building>();
                foreach (var b in buildings)
                {
                    buildingsList.Add(b);
                }
                return buildingsList;


            }
            catch
            {
                return null;
            }
        }

       }

    }

   

