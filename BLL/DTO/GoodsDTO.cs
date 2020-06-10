using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class GoodsDTO : IMapFrom<Goods>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Volume { get; set; }
        public string Toxicity { get; set; }
        public DateTime DateOfMan { get; set; }
        public DateTime DateOfExpire { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Goods, GoodsDTO>()
                .ForMember(d => d.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(d => d.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(d => d.Volume, opt => opt.MapFrom(src => src.Volume))
                .ForMember(d => d.Toxicity, opt => opt.MapFrom(src => src.Toxicity))
                .ForMember(d => d.DateOfMan, opt => opt.MapFrom(src => src.DateInfo.DateOfMan))
                .ForMember(d => d.DateOfExpire, opt => opt.MapFrom(src => src.DateInfo.DateOfExpire))
                .ReverseMap()
                .ForPath(s => s.Title, opt => opt.MapFrom(src => src.Title))
                .ForPath(s => s.Description, opt => opt.MapFrom(src => src.Description))
                .ForPath(s => s.Volume, opt => opt.MapFrom(src => src.Volume))
                .ForPath(s => s.Toxicity, opt => opt.MapFrom(src => src.Toxicity))
                .ForPath(s => s.DateInfo.DateOfMan, opt => opt.MapFrom(src => src.DateOfMan))
                .ForPath(s => s.DateInfo.DateOfExpire, opt => opt.MapFrom(src => src.DateOfExpire));
        }
    }
