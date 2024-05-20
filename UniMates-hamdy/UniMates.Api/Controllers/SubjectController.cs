using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public SubjectController(ISubjectReposaitory subjectReposaitory)
        {
            _subjectReposaitory = subjectReposaitory;
        }

        // GET: api/Subjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subject>>> GetAllSubjects()
        {
            var subjects = await _subjectReposaitory.GetAllSubjectsAsync();
            return Ok(subjects);
        }

        // GET: api/Subjects/session/{sessionId}
        [HttpGet("session/{sessionId}")]
        public async Task<ActionResult<Subject>> GetComplaintBySessionId(Guid sessionId)
        {
            var subject = await _subjectReposaitory.GetSubjectBySessionIdAsync(sessionId);
            if (subject == null)
            {
                return NotFound();
            }
            return Ok(subject);
        }
    }
}
