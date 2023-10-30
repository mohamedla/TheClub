using ClubModels.Models.GeneralCodes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ClubModels.Configuration.GeneralCodes
{
    public class NationalityCodesConfiguration : IEntityTypeConfiguration<NationalityCode>
    {
        public void Configure(EntityTypeBuilder<NationalityCode> builder)
        {
            builder.HasData(

                new NationalityCode { Id = Guid.NewGuid(), Code = 1, Name = "مصرى/ة" },
                new NationalityCode { Id = Guid.NewGuid(), Code = 2, Name = "سعودى/ة" },
                new NationalityCode { Id = Guid.NewGuid(), Code = 3, Name = "كويتى/ة" },
                new NationalityCode { Id = Guid.NewGuid(), Code = 4, Name = "إماراتى/ة" }
                );
        }
    }
}
