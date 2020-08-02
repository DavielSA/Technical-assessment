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
    [Route(ApiURL.PATH_LANG)]
    [ApiController]
    public class LangController : ControllerBase
    {

        private readonly ILangService service;

        public LangController(ILangService service) => this.service = service;

        // GET: api/Lang
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(this.service.Get());
        }

        // GET: api/Lang/5
        [HttpGet("{id}", Name = "Gets")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(this.service.Get(id));
        }

        // POST: api/Lang
        [HttpPost]
        public IActionResult Post([FromBody] Lang value)
        {
            return new OkObjectResult(this.service.Save(value));
        }

        // PUT: api/Lang/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Lang value)
        {
            Lang saved = this.service.Update(id, value);
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
