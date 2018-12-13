using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class RestaurangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestaurangController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<controller>
        [HttpGet]
        public ActionResult<List<Restauranger>> GetRestaurants()
        {            
            return _context.Restauranger.ToList();
        }


        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
