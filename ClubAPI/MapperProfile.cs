using AutoMapper;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubEntities.DataTransferObjects.GenderCodes;
using ClubEntities.DataTransferObjects.JobCodes;
using ClubEntities.DataTransferObjects.MartialStatusCodes;
using ClubEntities.DataTransferObjects.MembershipCodes;
using ClubEntities.DataTransferObjects.NationalityCodes;
using ClubEntities.DataTransferObjects.QualificationCodes;
using ClubEntities.DataTransferObjects.ReferenceCodes;
using ClubEntities.DataTransferObjects.ReligionCodes;
using ClubEntities.DataTransferObjects.SectionCodes;
using ClubEntities.DataTransferObjects.TitleCodes;
using ClubEntities.DataTransferObjects.TransferCodes;
using ClubModels.Models.GeneralCodes;

namespace ClubAPI
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<CityCodeCreateDTO, CityCode>();
            CreateMap<CityCodeEditDTO, CityCode>();

            CreateMap<GenderCodeCreateDTO, GenderCode>();
            CreateMap<GenderCodeEditDTO, GenderCode>();

            CreateMap<JobCodeCreateDTO, JobCode>();
            CreateMap<JobCodeEditDTO, JobCode>();

            CreateMap<MartialStatusCodeCreateDTO, MartialStatusCode>();
            CreateMap<MartialStatusCodeEditDTO, MartialStatusCode>();

            CreateMap<MembershipCodeCreateDTO, MembershipCode>();
            CreateMap<MembershipCodeEditDTO, MembershipCode>();

            CreateMap<NationalityCodeCreateDTO, NationalityCode>();
            CreateMap<NationalityCodeEditDTO, NationalityCode>();

            CreateMap<QualificationCodeCreateDTO, QualificationCode>();
            CreateMap<QualificationCodeEditDTO, QualificationCode>();

            CreateMap<ReferenceCodeCreateDTO, ReferenceCode>();
            CreateMap<ReferenceCodeEditDTO, ReferenceCode>();

            CreateMap<ReligionCodeCreateDTO, ReligionCode>();
            CreateMap<ReligionCodeEditDTO, ReligionCode>();

            CreateMap<SectionCodeCreateDTO, SectionCode>();
            CreateMap<SectionCodeEditDTO, SectionCode>();

            CreateMap<TitleCodeCreateDTO, TitleCode>();
            CreateMap<TitleCodeEditDTO, TitleCode>();

            CreateMap<TransferCodeCreateDTO, TransferCode>();
            CreateMap<TransferCodeEditDTO, TransferCode>();
        }
    }
}
