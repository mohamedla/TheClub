using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface IMartialStatusCodeRepository
    {
        IEnumerable<MartialStatusCode> GetAll(bool trackChanges);
        MartialStatusCode GetById(Guid id, bool trackChanges);
        void CreateEntity(MartialStatusCode entity);
        void DeleteEntity(MartialStatusCode entity);

        Task<IEnumerable<MartialStatusCode>> GetAllAsync(bool trackChanges);
        Task<MartialStatusCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<MartialStatusCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
