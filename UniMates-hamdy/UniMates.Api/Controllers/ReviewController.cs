using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Repositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{
    
    public class ReviewController : BaseApiController
    {
        private readonly IReviewReposaitory _reviewRepository;

        public ReviewController(IReviewReposaitory reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        // GET: api/Reviwss
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetAllReviews()
        {
            var reviews = await _reviewRepository.GetAllReviewsAsync();
            return Ok(reviews);
        }

        // GET: api/Reviews/session/{sessionId}
        [HttpGet("student/{studentId}")]
        public async Task<ActionResult<Review>> GetComplaintBySessionId(Guid studentId)
        {
            var review = await _reviewRepository.GetReviewsBySessionIdAsync(studentId);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        // GET: api/Reviwes/student/{studentId}
        [HttpGet("session/{sessionId}")]
        public async Task<ActionResult<Review>> GetreviewByStudentId(Guid sessionId)
        {
            var review = await _reviewRepository.GetReviewsBySessionIdAsync(sessionId);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }
    }
}
