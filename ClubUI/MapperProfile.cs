using AutoMapper;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubEntities.DataTransferObjects.GenderCodes;
using ClubEntities.DataTransferObjects.JobCodes;
using ClubEntities.DataTransferObjects.MartialStatusCodes;
using ClubEntities.DataTransferObjects.Member;
using ClubEntities.DataTransferObjects.MembershipCodes;
using ClubEntities.DataTransferObjects.NationalityCodes;
using ClubEntities.DataTransferObjects.QualificationCodes;
using ClubEntities.DataTransferObjects.ReferenceCodes;
using ClubEntities.DataTransferObjects.ReligionCodes;
using ClubEntities.DataTransferObjects.SectionCodes;
using ClubEntities.DataTransferObjects.TitleCodes;
using ClubEntities.DataTransferObjects.TransferCodes;
using ClubModels.Models;
using ClubModels.Models.GeneralCodes;

namespace ClubAPI
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<CityCode, CityCodeCreateDTO>();
            CreateMap<CityCode, CityCodeEditDTO>();
            CreateMap<CityCode, CityCode>();

            CreateMap<GenderCode, GenderCodeCreateDTO>();
            CreateMap<GenderCode, GenderCodeEditDTO>();
            CreateMap<GenderCode, GenderCode>();

            CreateMap<JobCode, JobCodeCreateDTO>();
            CreateMap<JobCode, JobCodeEditDTO>();
            CreateMap<JobCode, JobCode>();

            CreateMap<MartialStatusCode, MartialStatusCodeCreateDTO>();
            CreateMap<MartialStatusCode, MartialStatusCodeEditDTO>();
            CreateMap<MartialStatusCode, MartialStatusCode>();

            CreateMap<MembershipCode, MembershipCodeCreateDTO>();
            CreateMap<MembershipCode, MembershipCodeEditDTO>();
            CreateMap<MembershipCode, MembershipCode>();

            CreateMap<NationalityCode, NationalityCodeCreateDTO>();
            CreateMap<NationalityCode, NationalityCodeEditDTO>();
            CreateMap<NationalityCode, NationalityCode>();

            CreateMap<QualificationCode, QualificationCodeCreateDTO>();
            CreateMap<QualificationCode, QualificationCodeEditDTO>();
            CreateMap<QualificationCode, QualificationCode>();

            CreateMap<ReferenceCode, ReferenceCodeCreateDTO>();
            CreateMap<ReferenceCode, ReferenceCodeEditDTO>();
            CreateMap<ReferenceCode, ReferenceCode>();

            CreateMap<ReligionCode, ReligionCodeCreateDTO>();
            CreateMap<ReligionCode, ReligionCodeEditDTO>();
            CreateMap<ReligionCode, ReligionCode>();

            CreateMap<SectionCode, SectionCodeCreateDTO>();
            CreateMap<SectionCode, SectionCodeEditDTO>();
            CreateMap<SectionCode, SectionCode>();

            CreateMap<TitleCode, TitleCodeCreateDTO > ();
            CreateMap<TitleCode, TitleCodeEditDTO>();
            CreateMap<TitleCode, TitleCode>();

            CreateMap<TransferCode, TransferCodeCreateDTO>();
            CreateMap<TransferCode, TransferCodeEditDTO>();
            CreateMap<TransferCode, TransferCode>();

            CreateMap<Member, MemberDataCreateDTO>();
            CreateMap<Member, MemberDataUpdateDTO>();
            CreateMap<MemberDataDTO, MemberDataUpdateDTO>();
            CreateMap<MemberDataDTO, MemberDataCreateDTO>();
        }
    }
}
