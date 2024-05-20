using UniMates.Models;

namespace UniMates.Infrastructure.Contracts.IRepositories
{
    public interface IReviewReposaitory 
    {
        Task<IEnumerable<Review?>> GetAllReviewsAsync();
        Task<Review?> GetReviewBystudentId(Guid studentId);
        Task<Review?> GetReviewsBySessionIdAsync(Guid sessionId);
    }
}

// Reviews
// Session

// Session/{sessionId}/Reviews

// Include(x=>x.user)
    

