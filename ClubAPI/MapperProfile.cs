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
            CreateMap<CityCodeCreateDTO, CityCode>();
            CreateMap<CityCodeEditDTO, CityCode>();
            CreateMap<CityCode, CityCodeDTO>();

            CreateMap<GenderCodeCreateDTO, GenderCode>();
            CreateMap<GenderCodeEditDTO, GenderCode>();
            CreateMap<GenderCode, GenderCodeDTO>();

            CreateMap<JobCodeCreateDTO, JobCode>();
            CreateMap<JobCodeEditDTO, JobCode>();
            CreateMap<JobCode, JobCodeDTO>();

            CreateMap<MartialStatusCodeCreateDTO, MartialStatusCode>();
            CreateMap<MartialStatusCodeEditDTO, MartialStatusCode>();
            CreateMap<MartialStatusCode, MartialStatusCodeDTO>();

            CreateMap<MembershipCodeCreateDTO, MembershipCode>();
            CreateMap<MembershipCodeEditDTO, MembershipCode>();
            CreateMap<MembershipCode, MembershipCodeDTO>();

            CreateMap<NationalityCodeCreateDTO, NationalityCode>();
            CreateMap<NationalityCodeEditDTO, NationalityCode>();
            CreateMap<NationalityCode, NationalityCodeDTO>();

            CreateMap<QualificationCodeCreateDTO, QualificationCode>();
            CreateMap<QualificationCodeEditDTO, QualificationCode>();
            CreateMap<QualificationCode, QualificationCodeDTO>();

            CreateMap<ReferenceCodeCreateDTO, ReferenceCode>();
            CreateMap<ReferenceCodeEditDTO, ReferenceCode>();
            CreateMap<ReferenceCode, ReferenceCodeDTO>();

            CreateMap<ReligionCodeCreateDTO, ReligionCode>();
            CreateMap<ReligionCodeEditDTO, ReligionCode>();
            CreateMap<ReligionCode, ReligionCodeDTO>();

            CreateMap<SectionCodeCreateDTO, SectionCode>();
            CreateMap<SectionCodeEditDTO, SectionCode>();
            CreateMap<SectionCode, SectionCodeDTO>();

            CreateMap<TitleCodeCreateDTO, TitleCode>();
            CreateMap<TitleCodeEditDTO, TitleCode>();
            CreateMap<TitleCode, TitleCodeDTO>();

            CreateMap<TransferCodeCreateDTO, TransferCode>();
            CreateMap<TransferCodeEditDTO, TransferCode>();
            CreateMap<TransferCode, TransferCodeDTO>();

            CreateMap<MemberDataCreateDTO, Member>();
            CreateMap<MemberDataUpdateDTO, Member>();
            CreateMap<Member, MemberDataDTO>();
            CreateMap<MemberMetaDataDTO, MemberMetaDataDTO>(); 
        }
    }
}
