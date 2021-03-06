﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPNew.Service.Data;
using BPNew.Service.Models;
using BPNew.Service.ViewModels;
using BPNewBO.Meeting;
using Microsoft.EntityFrameworkCore;

namespace BPNew.Service.Services.MeetingRepository
{
    public class MeetingRepository : IMeetingRepository
    {
        private AppDbMigrationContext _appDBContext;
        public MeetingRepository(AppDbMigrationContext applicationDbContext)
        {
            _appDBContext = applicationDbContext;
        }
        public async Task<List<MeetingModel>> GetMeetings()
        {
            //var meetings = _appDBContext.Meetings.Select(a => new
            //{
            //    meetingId = a.MeetingId,
            //    date = a.Date,
            //    subject = a.Subject,
            //    status = a.Status,
            //    subCategoryModel = a.SubCategory
            //}).ToList();

            var meetings = await _appDBContext.Meetings.Select(a => new MeetingModel
            {
                MeetingId = a.MeetingId,
                Date = a.Date,
                Subject = a.Subject,
                Status = a.Status,
                SubCategoryModel = new BPNewBO.SubCategory.SubCategoryModel()
                {
                    Name = a.SubCategory.Name,
                    SubCategoryId = a.SubCategory.SubCategoryId,
                    Status = a.SubCategory.Status
                },
                CategoryModel = new BPNewBO.Category.CategoryModel()
                {
                    CategoryId = a.SubCategory.Category.CategoryId,
                    Name = a.SubCategory.Category.Name,
                    Status = a.SubCategory.Category.Status
                }
            }).ToListAsync();

            return meetings;
        }

        public async Task<MeetingModel> CreateMeeting(Meetings meetingEntity)
        {
            await _appDBContext.Meetings.AddAsync(meetingEntity);
            var result = await _appDBContext.SaveChangesAsync();

            return await GetMeetingById(meetingEntity.MeetingId);
        }

        public async Task<MeetingModel> GetMeetingById(int meetingId)
        {
            var meeting = await _appDBContext.Meetings.Where(m => m.MeetingId == meetingId)
                                                .Select(a => new MeetingModel
                                                {
                                                    MeetingId = a.MeetingId,
                                                    Date = a.Date,
                                                    Subject = a.Subject,
                                                    Status = a.Status,
                                                    SubCategoryModel = new BPNewBO.SubCategory.SubCategoryModel()
                                                    {
                                                        Name = a.SubCategory.Name,
                                                        SubCategoryId = a.SubCategory.SubCategoryId,
                                                        Status = a.SubCategory.Status
                                                    },
                                                    CategoryModel = new BPNewBO.Category.CategoryModel()
                                                    {
                                                        CategoryId = a.SubCategory.Category.CategoryId,
                                                        Name = a.SubCategory.Category.Name,
                                                        Status = a.SubCategory.Category.Status
                                                    }
                                                }).FirstOrDefaultAsync();

            return meeting;
        }
    }
}
