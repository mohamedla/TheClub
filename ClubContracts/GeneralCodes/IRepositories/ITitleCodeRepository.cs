using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface ITitleCodeRepository
    {
        IEnumerable<TitleCode> GetAll(bool trackChanges);
        TitleCode GetById(Guid id, bool trackChanges);
        void CreateEntity(TitleCode entity);
        void DeleteEntity(TitleCode entity);

        Task<IEnumerable<TitleCode>> GetAllAsync(bool trackChanges);
        Task<TitleCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<TitleCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
