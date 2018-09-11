using BPNewBO.MeetingTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPNew.Service.Services.MeetingTemplateRepository
{
    public interface IMeetingTemplateRepository
    {
        Task<List<MeetingTemplateModel>> GetVenuePanels();
    }
}
