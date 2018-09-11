using BPNewBO.Category;
using BPNewBO.MeetingTemplate;
using BPNewBO.SubCategory;
using BPNewBO.UserMgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPNew.Service.ViewModels
{
    public class MeetingViewModel
    {
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int CustomUserId { get; set; }
        public int MeetingTemplateId { get; set; }
        public List<CategoryModel> CategoryList { get; set; }
        public List<SubCategoryModel> SubCategoryList { get; set; }
        public DateTime MeetingDate { get; set; }
        public DateTime Date { get; set; }
        public string MeetingStartTime { get; set; }
        public string MeetingEndTime { get; set; }
        public List<UserReadModel> OrganizerList { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<MeetingTemplateModel> MeetingVenueList { get; set; }
        public string MeetingAt { get; set; }
        public string MeetingRoomName { get; set; }
        public string GeoLocation { get; set; }
    }
}
