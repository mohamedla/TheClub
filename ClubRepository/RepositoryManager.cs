using ClubContracts;
using ClubContracts.GeneralCodes.IRepositories;
using ClubModels;
using ClubModels.Models.GeneralCodes;
using ClubRepository.Repositories.GeneralCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubRepository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;

        #region General Codes Holders
        private ICityCodeRepository _CityCodeRepo;
        private IGenderCodeRepository _GenderCodeRepo;
        private IJobCodeRepository _JobCodeRepo;
        private IMartialStatusCodeRepository _MartialStatusCodeRepo;
        private IMembershipCodeRepository _MembershipCodeRepo;
        private INationalityCodeRepository _NationalityCodeRepo;
        private IQualificationCodeRepository _QualificationCodeRepo;
        private IReferenceCodeRepository _ReferenceCodeRepo;
        private IReligionCodeRepository _ReligionCodeRepo;
        private ISectionCodeRepository _SectionCodeRepo;
        private ITitleCodeRepository _TitleCodeRepo;
        private ITransferCodeRepository _TransferCodeRepo;
        #endregion

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        #region General Code Repos
        public ICityCodeRepository CityCode
        {
            get
            {
                if (_CityCodeRepo == null)
                    _CityCodeRepo = new CityCodeRepository(_repositoryContext);
                return _CityCodeRepo;
            }
        }
        public IGenderCodeRepository GenderCode
        {
            get
            {
                if (_GenderCodeRepo == null)
                    _GenderCodeRepo = new GenderCodeRepository(_repositoryContext);
                return _GenderCodeRepo;
            }
        }
        public IJobCodeRepository JobCode
        {
            get
            {
                if (_JobCodeRepo == null)
                    _JobCodeRepo = new JobCodeRepository(_repositoryContext);
                return _JobCodeRepo;
            }
        }
        public IMartialStatusCodeRepository MartialStatusCode
        {
            get
            {
                if (_MartialStatusCodeRepo == null)
                    _MartialStatusCodeRepo = new MartialStatusCodeRepository(_repositoryContext);
                return _MartialStatusCodeRepo;
            }
        }
        public IMembershipCodeRepository MembershipCode
        {
            get
            {
                if (_MembershipCodeRepo == null)
                    _MembershipCodeRepo = new MembershipCodeRepository(_repositoryContext);
                return _MembershipCodeRepo;
            }
        }
        public INationalityCodeRepository NationalityCode
        {
            get
            {
                if (_NationalityCodeRepo == null)
                    _NationalityCodeRepo = new NationalityCodeRepository(_repositoryContext);
                return _NationalityCodeRepo;
            }
        }
        public IQualificationCodeRepository QualificationCode
        {
            get
            {
                if (_QualificationCodeRepo == null)
                    _QualificationCodeRepo = new QualificationCodeRepository(_repositoryContext);
                return _QualificationCodeRepo;
            }
        }
        public IReferenceCodeRepository ReferenceCode
        {
            get
            {
                if (_ReferenceCodeRepo == null)
                    _ReferenceCodeRepo = new ReferenceCodeRepository(_repositoryContext);
                return _ReferenceCodeRepo;
            }
        }
        public IReligionCodeRepository ReligionCode
        {
            get
            {
                if (_ReligionCodeRepo == null)
                    _ReligionCodeRepo = new ReligionCodeRepository(_repositoryContext);
                return _ReligionCodeRepo;
            }
        }
        public ISectionCodeRepository SectionCode
        {
            get
            {
                if (_SectionCodeRepo == null)
                    _SectionCodeRepo = new SectionCodeRepository(_repositoryContext);
                return _SectionCodeRepo;
            }
        }
        public ITitleCodeRepository TitleCode
        {
            get
            {
                if (_TitleCodeRepo == null)
                    _TitleCodeRepo = new TitleCodeRepository(_repositoryContext);
                return _TitleCodeRepo;
            }
        }
        public ITransferCodeRepository TransferCode
        {
            get
            {
                if (_TransferCodeRepo == null)
                    _TransferCodeRepo = new TransferCodeRepository(_repositoryContext);
                return _TransferCodeRepo;
            }
        }
        #endregion

        public void Save() => _repositoryContext.SaveChanges();

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
