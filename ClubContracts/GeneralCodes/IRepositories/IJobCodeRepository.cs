using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface IJobCodeRepository
    {
        IEnumerable<JobCode> GetAll(bool trackChanges);
        JobCode GetById(Guid id, bool trackChanges);
        void CreateEntity(JobCode entity);
        void DeleteEntity(JobCode entity);

        Task<IEnumerable<JobCode>> GetAllAsync(bool trackChanges);
        Task<JobCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<JobCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
