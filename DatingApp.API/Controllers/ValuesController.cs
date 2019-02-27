using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly EmployeeDbContext _context;
        public ValuesController(EmployeeDbContext context)
        {
            _context = context;

        }
       /* 
        [HttpGet]
        public IActionResult Get()
        {
            var info=_context.GetEmployee.ToList();
            return Ok(info);
        }
        */

        //Using async task
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var info= await _context.GetEmployee.ToListAsync();
            return Ok(info);
        }
        /*
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var emp=_context.GetEmployee.FirstOrDefault(x=>x.Id==id);
            return Ok(emp);
        }
        */
        //Using async task
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var emp=await _context.GetEmployee.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(emp);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
