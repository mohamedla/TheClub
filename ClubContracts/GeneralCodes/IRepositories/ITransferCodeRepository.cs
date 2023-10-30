using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface ITransferCodeRepository
    {
        IEnumerable<TransferCode> GetAll(bool trackChanges);
        TransferCode GetById(Guid id, bool trackChanges);
        void CreateEntity(TransferCode entity);
        void DeleteEntity(TransferCode entity);

        Task<IEnumerable<TransferCode>> GetAllAsync(bool trackChanges);
        Task<TransferCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<TransferCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
