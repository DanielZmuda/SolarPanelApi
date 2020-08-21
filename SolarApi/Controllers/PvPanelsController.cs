using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.ResourceParameters;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PvPanelsController : ControllerBase
    {
        private readonly IPvPanelRepositoryBLL _repositoryBLL;

        public PvPanelsController(IPvPanelRepositoryBLL repositoryBLL)
        {
            _repositoryBLL = repositoryBLL;
        }
        // GET: api/<PvPanelsController>
        [HttpGet]
        public IActionResult Get(PvPanelResourceParameters pvPanelResourceParameters)
        {
            return Ok(_repositoryBLL.GetPvPanels(pvPanelResourceParameters));
        }

        // GET api/<PvPanelsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repositoryBLL.GetPvPanel(id));
        }

        // POST api/<PvPanelsController>
        [HttpPost]
        public IActionResult Post([FromBody] PvPanel model)
        {
            _repositoryBLL.AddEntity(model);
            return NoContent();
        }

        // PUT api/<PvPanelsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PvPanelsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repositoryBLL.DeletePvPanel(id);
            return NoContent();
        }
    }
}
