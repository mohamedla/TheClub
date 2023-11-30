using ClubContracts.Members.IRepository;
using ClubEntities.DataTransferObjects.Member;
using ClubModels;
using ClubModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClubRepository.Repositories
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }
        public void CreateEntity(Member entity)
            => Create(entity);

        public void DeleteEntity(Member entity)
            => Delete(entity);

        public IEnumerable<Member> GetAll(bool trackChanges)
            => FindAll(trackChanges).OrderBy(x => x.Name).ToList();

        public async Task<IEnumerable<MemberMetaDataDTO>> GetAllMetaDataOnlyAsync()
        {
            var members = FindAll(false).OrderBy(x => x.Name);

            var membersMetaData = from m in members.Include(x => x.TitleCode)
                                  select new MemberMetaDataDTO 
                                  { 
                                      Id = m.Id, 
                                      Title = m.TitleCode.Name, 
                                      Name = m.Name, 
                                      IdNo = m.IdNo,
                                      MemberNo = m.MemberNo
                                  };
            return await membersMetaData.ToListAsync();
        }

        public async Task<IEnumerable<Member>> GetAllAsync(bool trackChanges)
            => await FindAll(trackChanges).OrderBy(x => x.Name).ToListAsync();

        public Member GetById(Guid id, bool trackChanges)
            => FindByCondition(x => x.Id.Equals(id), trackChanges).SingleOrDefault();

        public async Task<Member> GetByIdAsync(Guid id, bool trackChanges)
            => await FindByCondition(x => x.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<Member>> GetByIdNoAsync(string idNo)
            => await FindByCondition(x => x.IdNo.Equals(idNo), false).ToListAsync();
    }
}
