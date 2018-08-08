using BPNewBO.Category;
using BPNewBO.SubCategory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPNewBO.Meeting
{
    public class MeetingModel
    {
        public int MeetingId { get; set; }
        public DateTime? Date { get; set; }
        public string Subject { get; set; }
        public byte Status { get; set; }
        public CategoryModel CategoryModel { get; set; }
        public SubCategoryModel SubCategoryModel { get; set; }
    }
}
