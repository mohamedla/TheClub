using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface IMembershipCodeRepository
    {
        IEnumerable<MembershipCode> GetAll(bool trackChanges);
        MembershipCode GetById(Guid id, bool trackChanges);
        void CreateEntity(MembershipCode entity);
        void DeleteEntity(MembershipCode entity);

        Task<IEnumerable<MembershipCode>> GetAllAsync(bool trackChanges);
        Task<MembershipCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<MembershipCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
