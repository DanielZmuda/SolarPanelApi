using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.PvSystemBLL;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PvSystemsController : ControllerBase
    {
        private readonly IPvSystemRepositoryBLL _repositoryBLL;

        public PvSystemsController(IPvSystemRepositoryBLL repositoryBLL)
        {
            _repositoryBLL = repositoryBLL;
        }
        // GET: api/<PvSystemsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositoryBLL.GetPvSystems());
        }

        // GET api/<PvSystemsController>/5
        [HttpGet("{pvSystemid}")]
        public IActionResult Get(int pvSystemid)
        {
            return Ok(_repositoryBLL.GetPvSystem(pvSystemid));
        }

        // POST api/<PvSystemsController>
        [HttpPost]
        public IActionResult Post([FromBody] PvSystem model)
        {
            _repositoryBLL.AddEntity(model);
            return NoContent();
        }

        // PUT api/<PvSystemsController>/5
        [HttpPatch("{pvSystemid}")]
        public void Patch(int pvSystemid,int pvPanelid, JsonPatchDocument<PvSystem> patchDocument)
        {


            var pvsystem = new PvSystem();
            _repositoryBLL.AddPvPanelToTheSystem(pvSystemid, pvPanelid);
        }

        // DELETE api/<PvSystemsController>/5
        [HttpDelete("{pvSystemid}")]
        public void Delete(int pvSystemid)
        {
            _repositoryBLL.DeletePvSystem(pvSystemid);
        }
    }
}
