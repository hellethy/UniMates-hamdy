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
    public class SessionReposaitory : ISessionReposaitory
    {
        private readonly ApplicationDbContext _dbContext;

        public SessionReposaitory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Session?> GetsessionBySubjectIdAsync(Guid subjectId)
        {
            return await _dbContext.Sessions.FindAsync(subjectId);
        }

        public async Task<Session?> GetSessionByTutorIdAsync(Guid tutorId)
        {
            return await _dbContext.Sessions.FindAsync(tutorId);
        }
    }
}
