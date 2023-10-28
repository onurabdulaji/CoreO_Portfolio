using AutoMapper;
using Project.DTOLayer.DTOS.AdminDTOs;
using Project.EntityLayer.Models;

namespace Project.MVCUI.Map.Mapping
{
    public class MapManagers : Profile
    {
        public MapManagers()
        {
            CreateMap<SignUpVM, AppUser>();
        }
    }
}
