using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMates.Dtos;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Repositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : BaseApiController
    {
        private readonly ISubjectReposaitory _subjectReposaitory;
        private readonly IMapper _mapper;

        public SubjectController(ISubjectReposaitory subjectReposaitory ,IMapper mapper)
        {
            _subjectReposaitory = subjectReposaitory;
            _mapper = mapper;
        }

        // GET: api/Subjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectToReturnDto>>> GetAllSubjects()
        {
            var subjects = await _subjectReposaitory.GetAllSubjectsAsync();
             var subjectsToreturnDto = _mapper.Map<IEnumerable<SubjectToReturnDto>>(subjects);
            return Ok(subjectsToreturnDto);
        }

        // GET: api/Subjects/session/{sessionId}
        [HttpGet("session/{sessionId}")]
        public async Task<ActionResult<SubjectToReturnDto>> GetComplaintBySessionId(Guid sessionId)
        {
            var subject = await _subjectReposaitory.GetSubjectBySessionIdAsync(sessionId);
            if (subject == null)
            {
                return NotFound();
            }
            var subjectToReturnDto = _mapper.Map<SubjectToReturnDto>(subject);
            return Ok(subjectToReturnDto);
        }
    }
}
