using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvertersController : ControllerBase
    {
        private readonly IInverterRepositoryBLL _repositoryBLL;

        public InvertersController(IInverterRepositoryBLL repositoryBLL)
        {
            _repositoryBLL = repositoryBLL;
        }
        // GET: api/<InvertersController>
        [HttpGet]
        public IActionResult Get(InverterResourceParameters inverterResourceParameters)
        {
            return Ok(_repositoryBLL.GetAll(inverterResourceParameters));
        }

        // GET api/<InvertersController>/5
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
        public IActionResult Put(int id, Inverter model)
        {
            var inverter = _repositoryBLL.GetInverter(id);
            _repositoryBLL.PutInverters(inverter);
            return Ok(inverter);
        }

        [HttpPatch("{id}")]
        public IActionResult PatchInverters(int id,[FromBody] JsonPatchDocument<Inverter> jsonPatchDocument)
        {
            var inverter = _repositoryBLL.GetInverter(id);

            if (inverter == null)
            {
                return NotFound();
            }
            //validation
            jsonPatchDocument.ApplyTo(inverter);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return new ObjectResult(inverter);

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
