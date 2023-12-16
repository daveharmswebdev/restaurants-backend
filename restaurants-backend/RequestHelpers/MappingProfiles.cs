using AutoMapper;
using restaurants_backend.DTOs;
using restaurants_backend.entities;

namespace restaurants_backend.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Staff, StaffDto>();
            CreateMap<Staff, StaffDetailDto>();
            CreateMap<CreateStaffDto, Staff>();
            CreateMap<UpdateStaffDto, Staff>();
        }
    }
}