using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventersController : ControllerBase
    {
        private readonly IInverterRepositoryBLL _repositoryBLL;

        public InventersController(IInverterRepositoryBLL repositoryBLL)
        {
            _repositoryBLL = repositoryBLL;
        }
        // GET: api/<InventersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositoryBLL.GetAll());
        }

        // GET api/<InventersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repositoryBLL.GetInverter(id));
        }

        // POST api/<InventersController>
        [HttpPost]
        public ActionResult<IEnumerable<Inverter>> Post([FromBody] Inverter model)
        {
            _repositoryBLL.AddEntity(model);
            return Ok(model);
        }

        // PUT api/<InventersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InventersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repositoryBLL.DeleteInverter(id);
            return NoContent(); 
        }
    }
}
