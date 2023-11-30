using ClubEntities.DataTransferObjects.Member;
using ClubModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubContracts.Members.IRepository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAll(bool trackChanges);
        Member GetById(Guid id, bool trackChanges);
        void CreateEntity(Member entity);
        void DeleteEntity(Member entity);

        Task<IEnumerable<Member>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<MemberMetaDataDTO>> GetAllMetaDataOnlyAsync();
        Task<Member> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<Member>> GetByIdNoAsync(string idNo);
    }
}
