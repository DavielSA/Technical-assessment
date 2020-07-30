using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TechnicalAssessment.Constant;
using TechnicalAssessment.Model;
using TechnicalAssessment.Service;

namespace TechnicalAssessment.Controllers
{
    [Route(ApiURL.PATH_OWNER)]
    [ApiController]
    public class OwnerController : ControllerBase
    {

        private readonly IOwnerService service;

        public OwnerController(IOwnerService service) => this.service = service;

        // GET: api/Owner
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(this.service.Get());
        }

        // GET: api/Owner/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(this.service.Get(id));
        }

        // POST: api/Owner
        [HttpPost]
        public IActionResult Post([FromBody] Owner value)
        {
            return new OkObjectResult(this.service.Save(value));
        }

        // PUT: api/Owner/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Owner value)
        {
            Owner saved = this.service.Update(id, value);
            if (saved == null)
                return new NoContentResult();

            return new OkObjectResult(saved);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (this.service.Delete(id))
                return new OkResult();

            return new NoContentResult();
        }
    }
}
