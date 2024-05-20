using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Domain;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Models;

namespace UniMates.Infrastructure.Repositories
{
    public class TutorSubjectRepoSaitory : ITutorSubjectReposaitory
    {
        private readonly ApplicationDbContext _dbContext;

        public TutorSubjectRepoSaitory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<TutorSubject?> GetTutorSubjectBySubjectIdAsync(Guid subjectId)
        {
            return await _dbContext.TutorSubjects.FindAsync(subjectId);
        }

        public async Task<TutorSubject?> GetTutorSubjectByTutorIdAsync(Guid tutorId)
        {
            return await _dbContext.TutorSubjects.FindAsync(tutorId);
        }
    }
}
