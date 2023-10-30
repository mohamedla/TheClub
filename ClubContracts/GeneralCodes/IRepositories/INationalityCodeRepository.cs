using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface INationalityCodeRepository
    {
        IEnumerable<NationalityCode> GetAll(bool trackChanges);
        NationalityCode GetById(Guid id, bool trackChanges);
        void CreateEntity(NationalityCode entity);
        void DeleteEntity(NationalityCode entity);

        Task<IEnumerable<NationalityCode>> GetAllAsync(bool trackChanges);
        Task<NationalityCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<NationalityCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
