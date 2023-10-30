using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface ICityCodeRepository
    {
        IEnumerable<CityCode> GetAll(bool trackChanges);
        CityCode GetById(Guid id, bool trackChanges);
        void CreateEntity(CityCode entity);
        void DeleteEntity(CityCode entity);

        Task<IEnumerable<CityCode>> GetAllAsync(bool trackChanges);
        Task<CityCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<CityCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
