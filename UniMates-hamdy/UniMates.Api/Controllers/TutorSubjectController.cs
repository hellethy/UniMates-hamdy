using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Repositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{
 
    public class TutorSubjectController : BaseApiController
    {
        private readonly ITutorSubjectReposaitory _tutorSubjectReposaitory;

        public TutorSubjectController(ITutorSubjectReposaitory tutorSubjectReposaitory)
        {
           _tutorSubjectReposaitory = tutorSubjectReposaitory;
        }

        // GET: api/TutorSubjects/subject/{subjectId}
        [HttpGet("subject/{subjectId}")]
        public async Task<ActionResult<TutorSubject>> GetTutorSubjectBySubjectId(Guid subjectId)
        {
            var tutorSubject = await _tutorSubjectReposaitory.GetTutorSubjectBySubjectIdAsync(subjectId);
            if (tutorSubject == null)
            {
                return NotFound();
            }
            return Ok(tutorSubject);
        }

        // GET: api/TutorSubjects/tutor/{tutorId}
        [HttpGet("tutor/{tutorId}")]
        public async Task<ActionResult<TutorSubject>> GetTutorSubjectByTutorId(Guid tutorId)
        {
            var tutorSubject = await _tutorSubjectReposaitory.GetTutorSubjectByTutorIdAsync(tutorId);
            if (tutorSubject == null)
            {
                return NotFound();
            }
            return Ok(tutorSubject);
        }

    }
}
