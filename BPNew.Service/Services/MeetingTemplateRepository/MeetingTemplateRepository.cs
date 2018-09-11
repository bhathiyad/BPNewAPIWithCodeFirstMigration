using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPNew.Service.Models;
using BPNewBO.MeetingTemplate;
using Microsoft.EntityFrameworkCore;

namespace BPNew.Service.Services.MeetingTemplateRepository
{
    public class MeetingTemplateRepository : IMeetingTemplateRepository
    {
        private AppDbMigrationContext _appDBContext;
        public MeetingTemplateRepository(AppDbMigrationContext applicationDbContext)
        {
            _appDBContext = applicationDbContext;
        }
        public async Task<List<MeetingTemplateModel>> GetVenuePanels()
        {
            var venuePanelList = await _appDBContext.MeetingTemplates.Where(a => a.Status == 1)
                                    .Select(a => new MeetingTemplateModel()
                                    {
                                        MeetingTemplateId = a.MeetingTemplateId,
                                        TemplateName = a.TemplateName
                                    }).ToListAsync();

            return venuePanelList;
        }
    }
}
