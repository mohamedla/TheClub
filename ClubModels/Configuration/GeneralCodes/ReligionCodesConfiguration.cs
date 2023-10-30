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
    public class ReligionCodesConfiguration : IEntityTypeConfiguration<ReligionCode>
    {
        public void Configure(EntityTypeBuilder<ReligionCode> builder)
        {
            builder.HasData(

                new ReligionCode { Id = Guid.NewGuid(), Code = 1, Name = "مسلم/ة" },
                new ReligionCode { Id = Guid.NewGuid(), Code = 2, Name = "مسيحى/ة" },
                new ReligionCode { Id = Guid.NewGuid(), Code = 3, Name = "أخرى" }
                );
        }
    }
}
