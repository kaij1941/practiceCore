using AutoMapper;
using Practice.Service.Dtos;
using Practice.Service.Interface;
using System;

namespace Practice.Service
{
    public class Class1 : IClass1
    {
        private readonly IMapper _mapper;
        public Class1(IMapper mapper)
        {
            this._mapper = mapper;
        }
        public void Test()
        {

            var AA = new AA01
            {
                A01 = "01"
            };

            var BB = new BB01
            {
                B01 = "01"
            };

            var sample = _mapper.Map<AA01,AABB>(AA);
            sample = _mapper.Map<BB01,AABB>(BB,sample);

            var message = $"AA01 is {sample.AA01}, And BB01 is {sample.BB01}";
            Console.WriteLine(message);
        }

    }

}
