using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Repositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{

    public class SessionController : BaseApiController
    {
        private readonly ISessionReposaitory _sessionReposaitory;

        public SessionController(ISessionReposaitory sessionReposaitory)
        {
            _sessionReposaitory = sessionReposaitory;
        }
        // GET: api/Reviews/session/{sessionId}
        [HttpGet("subject/{subjectId}")]
        public async Task<ActionResult<Session>> GetComplaintBySessionId(Guid subjectId)
        {
            var session = await _sessionReposaitory.GetsessionBySubjectIdAsync(subjectId);
            if (session == null)
            {
                return NotFound();
            }
            return Ok(session);
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
            return Ok(session);
        }

    }
}
