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
    [Route(ApiURL.PATH_HOLIDAYHOME)]
    [ApiController]
    public class HolidayHomeController : ControllerBase
    {

        private readonly IHolidayHomeService service;

        public HolidayHomeController(IHolidayHomeService service) => this.service = service;

        // GET: api/HolidayHome
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(this.service.Get());
        }

        // GET: api/HolidayHome/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(this.service.Get(id));
        }

        // POST: api/HolidayHome
        [HttpPost]
        public IActionResult Post([FromBody] RespHolidayHome value)
        {
            HolidayHome hHome = new HolidayHome()
            {
                Id = value.Id,
                Alias = value.Alias,
                OwnerId = value.Owner.Id
            };
            return new OkObjectResult(this.service.Save(hHome));
        }

        // PUT: api/HolidayHome/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] HolidayHome value)
        {
            HolidayHome saved = this.service.Update(id, value);
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
