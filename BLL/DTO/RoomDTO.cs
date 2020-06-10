using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.Mapper;
using DAL.Entities;
using DAL.Entities.Enums;

namespace BLL.DTO
{
    public class RoomDTO : IMapFrom<Room>
    {
        public int Id { get; set; }
        public int TotalVolume { get; set; }
        public string Toxicity { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Room, RoomDTO>()
                .ForMember(d => d.TotalVolume, opt => opt.MapFrom(src => src.TotalVolume))
                .ForMember(d => d.Toxicity, opt => opt.MapFrom(src => src.Toxicity))
                .ReverseMap()
                .ForPath(s => s.TotalVolume, opt => opt.MapFrom(src => src.TotalVolume))
                .ForPath(s => s.Toxicity, opt => opt.MapFrom(src => src.Toxicity));
        }
    }
}
