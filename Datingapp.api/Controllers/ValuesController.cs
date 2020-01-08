using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Datingapp.api.Data;
using Microsoft.EntityFrameworkCore;

namespace Datingapp.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _dbContext;
        public ValuesController(DataContext context)
        {
            _dbContext = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _dbContext.Values.ToListAsync();
            return Ok(values);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var values = await _dbContext.Values.FirstOrDefaultAsync(x=>x.id == id);
            return Ok(values);
        } 
    }    
    
}