using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMates.Dtos;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Repositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{

    public class SessionController : BaseApiController
    {
        private readonly ISessionReposaitory _sessionReposaitory;
        private readonly IMapper _mapper;

        public SessionController(ISessionReposaitory sessionReposaitory,IMapper mapper)
        {
            _sessionReposaitory = sessionReposaitory;
            _mapper = mapper;
        }
        // GET: api/Reviews/session/{sessionId}
        [HttpGet("subject/{subjectId}")]
        public async Task<ActionResult<SessionToReturnDto>> GetComplaintBySessionId(Guid subjectId)
        {
            var session = await _sessionReposaitory.GetsessionBySubjectIdAsync(subjectId);
            if (session == null)
            {
                return NotFound();
            }
            var sessionToReturnDto = _mapper.Map<SessionToReturnDto>(session);
            return Ok(sessionToReturnDto);
        }

        // GET: api/Reviews/session/{sessionId}
        [HttpGet("tutor/{tutorId}")]
        public async Task<ActionResult<Session>> GetSessionBySubjectId(Guid tutorId)
        {
            var session = await _sessionReposaitory.GetSessionByTutorIdAsync(tutorId);
            if (session == null)
            {
                return NotFound();
            }
            var sessionToReturnDto = _mapper.Map<SessionToReturnDto>(session);
            return Ok(sessionToReturnDto);
        }

    }
}
