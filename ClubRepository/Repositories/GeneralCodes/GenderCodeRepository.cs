using ClubContracts.GeneralCodes.IRepositories;
using ClubModels;
using ClubModels.Models.GeneralCodes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ClubRepository.Repositories.GeneralCodes
{
    internal class GenderCodeRepository : RepositoryBase<GenderCode>, IGenderCodeRepository
    {

        public GenderCodeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { }
        public IEnumerable<GenderCode> GetAll(bool trackChanges)
             => FindAll(trackChanges).OrderBy(x => x.Code).ToList();

        public GenderCode GetById(Guid id, bool trackChanges)
            => FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefault();

        public void CreateEntity(GenderCode entity)
        => Create(entity);

        public void DeleteEntity(GenderCode entity)
        => Delete(entity);

        public async Task<IEnumerable<GenderCode>> GetAllAsync(bool trackChanges)
            => await FindAll(trackChanges).OrderBy(x => x.Code).ToListAsync();

        public async Task<GenderCode> GetByIdAsync(Guid id, bool trackChanges)
            => await FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<GenderCode>> GetByCodeAsync(int code, bool trackChanges)
            => await FindByCondition(s => s.Code.Equals(code), trackChanges).ToListAsync();
    }
}
