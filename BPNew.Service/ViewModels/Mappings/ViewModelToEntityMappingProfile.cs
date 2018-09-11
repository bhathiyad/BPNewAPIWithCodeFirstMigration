
using BPNew.Service.Models.Entities;
using AutoMapper;
using BPNew.Service.Models;

namespace BPNew.Service.ViewModels.Mappings
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
            CreateMap<MeetingViewModel, Meetings>().ForMember(em => em.StartTime, map => map.MapFrom(vm => System.Convert.ToDateTime(vm.MeetingStartTime).TimeOfDay))
                                                    .ForMember(em => em.EndTime, map => map.MapFrom(vm => System.Convert.ToDateTime(vm.MeetingEndTime).TimeOfDay))
                                                    .ForMember(em => em.Date, map => map.MapFrom(vm => vm.MeetingDate))
                                                    .ForMember(em => em.OrganizerId, map => map.MapFrom(vm => vm.CustomUserId));
        }
    }
}
