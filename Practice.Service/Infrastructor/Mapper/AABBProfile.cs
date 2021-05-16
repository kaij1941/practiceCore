using AutoMapper;
using Practice.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Service.Infrastructor.Mapper
{
    public class AABBProfile:Profile
    {
        public AABBProfile()
        {
            CreateMap<AA01, AABB>()
           .ForMember(x => x.AA01, y => y.MapFrom(o => o.A01))
           .ReverseMap();

            CreateMap<BB01, AABB>()
            .ForMember(x => x.BB01, y => y.MapFrom(o => o.B01))
            .ReverseMap();
        }
    }
}
