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
    internal class TransferCodeRepository : RepositoryBase<TransferCode>, ITransferCodeRepository
    {

        public TransferCodeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { }
        public IEnumerable<TransferCode> GetAll(bool trackChanges)
             => FindAll(trackChanges).OrderBy(x => x.Code).ToList();

        public TransferCode GetById(Guid id, bool trackChanges)
            => FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefault();

        public void CreateEntity(TransferCode entity)
        => Create(entity);

        public void DeleteEntity(TransferCode entity)
        => Delete(entity);

        public async Task<IEnumerable<TransferCode>> GetAllAsync(bool trackChanges)
            => await FindAll(trackChanges).OrderBy(x => x.Code).ToListAsync();

        public async Task<TransferCode> GetByIdAsync(Guid id, bool trackChanges)
            => await FindByCondition(s => s.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<TransferCode>> GetByCodeAsync(int code, bool trackChanges)
            => await FindByCondition(s => s.Code.Equals(code), trackChanges).ToListAsync();
    }
}
