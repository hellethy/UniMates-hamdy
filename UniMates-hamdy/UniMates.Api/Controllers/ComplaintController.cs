using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using UniMates.Dtos;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{
  
    public class ComplaintController : BaseApiController
    {
        private readonly IComplaintReposaitory _complaintReposaitory;
        private readonly IMapper _mapper;

        public ComplaintController(IComplaintReposaitory complaintReposaitory, IMapper mapper)
        {
            _complaintReposaitory = complaintReposaitory;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComplaintToReturnDto>>> GetComplaints()
        {
            var complaints =  await _complaintReposaitory.GetAllComplaintsAsync();
            var complaintsToReturnDto = _mapper.Map<IEnumerable<ComplaintToReturnDto>>(complaints);
            return Ok(complaintsToReturnDto);
        }

        // GET: api/Complaints/session/{sessionId}
        [HttpGet("session/{sessionId}")]
        public async Task<ActionResult<ComplaintToReturnDto>> GetComplaintBySessionId(Guid sessionId)
        {

            var complaint = await _complaintReposaitory.GetComplaintBySesstionIdAsync(sessionId);
            if (complaint == null)
            {
                return NotFound();
            }
            var complaintsToReturnDto = _mapper.Map<ComplaintToReturnDto>(complaint);
            return Ok(complaintsToReturnDto);
        }

        // GET: api/Complaints/student/{studentId}
        [HttpGet("student/{studentId}")]
        public async Task<ActionResult<Complaint>> GetComplaintByStudentId(Guid studentId)
        {
            var complaint = await _complaintReposaitory.GetComplaintByStudentIdAsync(studentId);
            if (complaint == null)
            {
                return NotFound();
            }
            
            var complaintsToReturnDto = _mapper.Map<ComplaintToReturnDto>(complaint);
            return Ok(complaintsToReturnDto);
        }
    }
}
