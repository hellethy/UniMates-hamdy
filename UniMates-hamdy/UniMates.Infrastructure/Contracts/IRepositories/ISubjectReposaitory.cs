using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Infrastructure.Contracts.IRepositories
{
    public interface ISubjectReposaitory
    {
        Task<Subject?> GetSubjectBySessionIdAsync(Guid sessionId);
        Task<IEnumerable<Subject?>> GetAllSubjectsAsync();
    }
}
