using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPNew.Service.Services.MeetingRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BPNew.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [Authorize]
    public class MeetingController : Controller
    {
        private IMeetingRepository _meetingRepository;
        public MeetingController(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        // GET: api/Meeting
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var meetingList = await _meetingRepository.GetMeetings();

            return new OkObjectResult(meetingList);
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Meeting/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Meeting
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Meeting/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
