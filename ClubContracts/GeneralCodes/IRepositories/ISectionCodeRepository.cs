using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface ISectionCodeRepository
    {
        IEnumerable<SectionCode> GetAll(bool trackChanges);
        SectionCode GetById(Guid id, bool trackChanges);
        void CreateEntity(SectionCode entity);
        void DeleteEntity(SectionCode entity);

        Task<IEnumerable<SectionCode>> GetAllAsync(bool trackChanges);
        Task<SectionCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<SectionCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
