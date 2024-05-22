using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMates.Dtos;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Repositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{
 
    public class TutorSubjectController : BaseApiController
    {
        private readonly ITutorSubjectReposaitory _tutorSubjectReposaitory;
        private readonly IMapper _mapper;

        public TutorSubjectController(ITutorSubjectReposaitory tutorSubjectReposaitory , IMapper mapper)
        {
           _tutorSubjectReposaitory = tutorSubjectReposaitory;
            _mapper = mapper;
        }

        // GET: api/TutorSubjects/subject/{subjectId}
        [HttpGet("subject/{subjectId}")]
        public async Task<ActionResult<TutorSubjectToReturnDto>> GetTutorSubjectBySubjectId(Guid subjectId)
        {
            var tutorSubject = await _tutorSubjectReposaitory.GetTutorSubjectBySubjectIdAsync(subjectId);
            if (tutorSubject == null)
            {
                return NotFound();
            }
            var tutorsubjectToReturnDto = _mapper.Map<TutorSubjectToReturnDto>(tutorSubject);
            return Ok(tutorsubjectToReturnDto);
        }

        // GET: api/TutorSubjects/tutor/{tutorId}
        [HttpGet("tutor/{tutorId}")]
        public async Task<ActionResult<TutorSubjectToReturnDto>> GetTutorSubjectByTutorId(Guid tutorId)
        {
            var tutorSubject = await _tutorSubjectReposaitory.GetTutorSubjectByTutorIdAsync(tutorId);
            if (tutorSubject == null)
            {
                return NotFound();
            }
            var tutorsubjectToReturnDto = _mapper.Map<TutorSubjectToReturnDto>(tutorSubject);
            return Ok(tutorsubjectToReturnDto);
        }

    }
}
