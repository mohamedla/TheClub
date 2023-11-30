using ClubContracts.GeneralCodes.IRepositories;
using ClubContracts.Members.IRepository;

namespace ClubContracts
{
    public interface IRepositoryManager
    {
        #region General Codes Repos
        ICityCodeRepository CityCode { get; }
        IGenderCodeRepository GenderCode { get; }
        IJobCodeRepository JobCode { get; }
        IMartialStatusCodeRepository MartialStatusCode{ get; }
        IMembershipCodeRepository MembershipCode { get; }
        INationalityCodeRepository NationalityCode { get; }
        IQualificationCodeRepository QualificationCode { get; }
        IReferenceCodeRepository ReferenceCode { get; }
        IReligionCodeRepository ReligionCode { get; }
        ISectionCodeRepository SectionCode { get; }
        ITitleCodeRepository TitleCode { get; }
        ITransferCodeRepository TransferCode { get; }
        #endregion

        IMemberRepository Member { get; }
        void Save();
        Task SaveAsync();

    }
}