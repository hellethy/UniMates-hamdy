using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Models;

namespace UniMates.Api.Controllers
{
  
    public class ComplaintController : BaseApiController
    {
        private readonly IComplaintReposaitory _complaintReposaitory;

        public ComplaintController(IComplaintReposaitory complaintReposaitory)
        {
            _complaintReposaitory = complaintReposaitory;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Complaint>>> GetComplaints()
        {
            var complaints =  await _complaintReposaitory.GetAllComplaintsAsync();
            return Ok(complaints);
        }

        // GET: api/Complaints/session/{sessionId}
        [HttpGet("session/{sessionId}")]
        public async Task<ActionResult<Complaint>> GetComplaintBySessionId(Guid sessionId)
        {
            var complaint = await _complaintReposaitory.GetComplaintBySesstionIdAsync(sessionId);
            if (complaint == null)
            {
                return NotFound();
            }
            return Ok(complaint);
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
            return Ok(complaint);
        }
    }
}
