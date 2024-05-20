using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Infrastructure.Contracts.IRepositories
{
    public interface ISessionReposaitory 
    {
        //seesion -- course
        Task<Session?> GetsessionBySubjectIdAsync(Guid subjectId);
        Task<Session?> GetSessionByTutorIdAsync(Guid tutorId);
  
    }
}
