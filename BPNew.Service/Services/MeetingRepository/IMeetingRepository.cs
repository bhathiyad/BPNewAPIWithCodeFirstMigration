using BPNew.Service.Models;
using BPNewBO.Meeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPNew.Service.Services.MeetingRepository
{
    public interface IMeetingRepository
    {
        Task<List<MeetingModel>> GetMeetings();
        Task<MeetingModel> CreateMeeting(Meetings meetingEntity);  
    }
}
