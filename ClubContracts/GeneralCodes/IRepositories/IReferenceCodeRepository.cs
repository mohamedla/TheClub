using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface IReferenceCodeRepository
    {
        IEnumerable<ReferenceCode> GetAll(bool trackChanges);
        ReferenceCode GetById(Guid id, bool trackChanges);
        void CreateEntity(ReferenceCode entity);
        void DeleteEntity(ReferenceCode entity);

        Task<IEnumerable<ReferenceCode>> GetAllAsync(bool trackChanges);
        Task<ReferenceCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<ReferenceCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
