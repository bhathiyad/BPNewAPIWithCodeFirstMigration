using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BPNew.Service.Hubs;
using BPNew.Service.Models;
using BPNew.Service.Services.CategoryRepository;
using BPNew.Service.Services.MeetingRepository;
using BPNew.Service.Services.MeetingTemplateRepository;
using BPNew.Service.Services.SubCategoryRepository;
using BPNew.Service.Services.UserMgtRepository;
using BPNew.Service.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace BPNew.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[Authorize]
    public class MeetingController : Controller
    {
        private readonly IHubContext<SyncHub> _synchubContext;
        private IMeetingRepository _meetingRepository;
        private IUserMgtRepository _userMgtRepository;
        private IMeetingTemplateRepository _meetingTemplateRepository;
        private ICategoryRepository _categoryRepository;
        private ISubCategoryRepository _subCategoryRepository;
        private readonly IMapper _mapper;
        public MeetingController(IMeetingRepository meetingRepository,
                                IUserMgtRepository userMgtRepository,
                                IMeetingTemplateRepository meetingTemplateRepository,
                                ICategoryRepository categoryRepository,
                                ISubCategoryRepository subCategoryRepository,
                                IMapper mapper,
                                IHubContext<SyncHub> synchubContext)
        {
            _meetingRepository = meetingRepository;
            _userMgtRepository = userMgtRepository;
            _meetingTemplateRepository = meetingTemplateRepository;
            _categoryRepository = categoryRepository;
            _subCategoryRepository = subCategoryRepository;
            _mapper = mapper;
            _synchubContext = synchubContext;
        }

        // GET: api/Meeting
        [Authorize]
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
        public async Task Post([FromBody]MeetingViewModel meetingViewModel)
        {
            var meetingEntity = _mapper.Map<Meetings>(meetingViewModel);
            meetingEntity.IsTentative = false;
            meetingEntity.CreatedDate = DateTime.Now;
            meetingEntity.CreatedBy = (int)meetingEntity.OrganizerId;
            meetingEntity.MeetingType = 0;

            var meetingModel = await _meetingRepository.CreateMeeting(meetingEntity);

            if (meetingModel != null)
            {
                await _synchubContext.Clients.All.SendAsync("SendMeetingData", meetingModel);
            }

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

        // GET: api/CreateMeetingGet/5
        [HttpGet]
        [Route("CreateMeetingGet")]
        public async Task<IActionResult> CreateMeetingGet()
        {
            var meetingViewModel = new MeetingViewModel()
            {
                CategoryList = await _categoryRepository.GetCategories(),
                SubCategoryList = await _subCategoryRepository.GetSubCategories(),
                MeetingVenueList = await _meetingTemplateRepository.GetVenuePanels(),
                OrganizerList = await _userMgtRepository.GetBoardSecrataries(12)
            };

            return new OkObjectResult(meetingViewModel);
            //return await Task.FromResult(new OkObjectResult("Ok"));
        }
    }
}
