using Microsoft.EntityFrameworkCore;
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
    public class SubjectReposaitory : ISubjectReposaitory
    {
        private readonly ApplicationDbContext _dbContext;

        public SubjectReposaitory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Subject?>> GetAllSubjectsAsync()
        {
            return await _dbContext.Subjects.ToListAsync();
        }

        public async Task<Subject?> GetSubjectBySessionIdAsync(Guid sessionId)
        {
            return await _dbContext.Subjects.FindAsync(sessionId);
        }
    }
}
