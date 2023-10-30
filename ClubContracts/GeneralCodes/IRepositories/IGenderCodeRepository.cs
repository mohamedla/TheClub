using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface IGenderCodeRepository
    {
        IEnumerable<GenderCode> GetAll(bool trackChanges);
        GenderCode GetById(Guid id, bool trackChanges);
        void CreateEntity(GenderCode entity);
        void DeleteEntity(GenderCode entity);

        Task<IEnumerable<GenderCode>> GetAllAsync(bool trackChanges);
        Task<GenderCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<GenderCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
