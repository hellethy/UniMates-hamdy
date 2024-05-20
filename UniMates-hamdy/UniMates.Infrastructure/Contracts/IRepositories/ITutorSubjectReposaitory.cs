using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Infrastructure.Contracts.IRepositories
{
    public interface ITutorSubjectReposaitory
    {
        Task<TutorSubject?> GetTutorSubjectByTutorIdAsync(Guid tutorId);
        Task<TutorSubject?> GetTutorSubjectBySubjectIdAsync(Guid subjectId);
    }
}
