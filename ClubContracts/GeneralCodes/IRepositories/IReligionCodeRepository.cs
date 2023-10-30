using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface IReligionCodeRepository
    {
        IEnumerable<ReligionCode> GetAll(bool trackChanges);
        ReligionCode GetById(Guid id, bool trackChanges);
        void CreateEntity(ReligionCode entity);
        void DeleteEntity(ReligionCode entity);

        Task<IEnumerable<ReligionCode>> GetAllAsync(bool trackChanges);
        Task<ReligionCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<ReligionCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
