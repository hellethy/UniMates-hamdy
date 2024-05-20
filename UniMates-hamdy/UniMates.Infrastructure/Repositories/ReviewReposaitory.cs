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
    public class ReviewReposaitory : IReviewReposaitory
    {
        private readonly ApplicationDbContext _dbContext;

        public ReviewReposaitory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Review?>> GetAllReviewsAsync()
        {
            return await _dbContext.Reviews.ToListAsync();
        }

        public async Task<Review?> GetReviewBystudentId(Guid studentId)
        {
            return await _dbContext.Reviews.FindAsync(studentId);
        }

        public async Task<Review?> GetReviewsBySessionIdAsync(Guid sessionId)
        {
            return await _dbContext.Reviews.FindAsync(sessionId);
        }
    }
}
