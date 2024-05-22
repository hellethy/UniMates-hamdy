using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMates.Dtos;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Repositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{
    
    public class ReviewController : BaseApiController
    {
        private readonly IReviewReposaitory _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewController(IReviewReposaitory reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        // GET: api/Reviwss
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewToReturnDto>>> GetAllReviews()
        {
            var reviews = await _reviewRepository.GetAllReviewsAsync();
            var reviewsToReturnDto = _mapper.Map<IEnumerable<ReviewToReturnDto>>(reviews);
            return Ok(reviews);
        }

        // GET: api/Reviews/session/{sessionId}
        [HttpGet("student/{studentId}")]
        public async Task<ActionResult<ReviewToReturnDto>> GetComplaintBySessionId(Guid studentId)
        {
            var review = await _reviewRepository.GetReviewsBySessionIdAsync(studentId);
            if (review == null)
            {
                return NotFound();
            }
            var reviewToReturnDto = _mapper.Map<ReviewToReturnDto>(review);
            return Ok(reviewToReturnDto);
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

            var reviewToReturnDto = _mapper.Map<ReviewToReturnDto>(review);
            return Ok(reviewToReturnDto);
        }
    }
}
