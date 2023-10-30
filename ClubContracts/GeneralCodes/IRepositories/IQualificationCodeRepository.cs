using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using ClubModels.Models.GeneralCodes;

namespace ClubContracts.GeneralCodes.IRepositories
{
    public interface IQualificationCodeRepository
    {
        IEnumerable<QualificationCode> GetAll(bool trackChanges);
        QualificationCode GetById(Guid id, bool trackChanges);
        void CreateEntity(QualificationCode entity);
        void DeleteEntity(QualificationCode entity);

        Task<IEnumerable<QualificationCode>> GetAllAsync(bool trackChanges);
        Task<QualificationCode> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<QualificationCode>> GetByCodeAsync(int code, bool trackChanges);
    }
}
