using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        private HomeService _homeService;

        public DBController(HomeService homeService) {
            _homeService = homeService;

        }


        // GET: api/DB
        [HttpGet]
        public Object Get()
        {

            _homeService.cretaDBFirst();
            return Ok();

        }

        // GET: api/DB/5
        [HttpGet("{id}", Name = "Get")]
        public object Get(int id)
        {
            var result =  _homeService.GetList();
            
            return Ok(result);
        }

        // POST: api/DB
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/DB/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
