using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Dtos;
using UniMates.Models;

namespace UniMates.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Complaint, ComplaintToReturnDto>().ReverseMap();
            CreateMap<Review, ReviewToReturnDto>().ReverseMap();
            CreateMap<Subject, SubjectToReturnDto>().ReverseMap();
            CreateMap<Session, SessionToReturnDto>().ReverseMap();
            CreateMap<TutorSubject, TutorSubjectToReturnDto>().ReverseMap();

        }
    }
}
