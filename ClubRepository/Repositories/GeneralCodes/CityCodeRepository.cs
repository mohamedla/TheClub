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
    internal class CityCodeRepository : RepositoryBase<CityCode>, ICityCodeRepository
    {

        public CityCodeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { }
        public IEnumerable<CityCode> GetAll(bool trackChanges)
             => FindAll(trackChanges).OrderBy(x => x.Code).ToList();

        public CityCode GetById(Guid id, bool trackChanges)
            => FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefault();

        public void CreateEntity(CityCode entity)
        => Create(entity);

        public void DeleteEntity(CityCode entity)
        => Delete(entity);

        public async Task<IEnumerable<CityCode>> GetAllAsync(bool trackChanges)
            => await FindAll(trackChanges).OrderBy(x => x.Code).ToListAsync();

        public async Task<CityCode> GetByIdAsync(Guid id, bool trackChanges)
            => await FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<CityCode>> GetByCodeAsync(int code, bool trackChanges)
            => await FindByCondition(s => s.Code.Equals(code), trackChanges).ToListAsync();
    }
}
