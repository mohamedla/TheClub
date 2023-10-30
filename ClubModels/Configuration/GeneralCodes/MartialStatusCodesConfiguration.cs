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
    public class MartialStatusCodesConfiguration : IEntityTypeConfiguration<MartialStatusCode>
    {
        public void Configure(EntityTypeBuilder<MartialStatusCode> builder)
        {
            builder.HasData(

                new MartialStatusCode { Id = Guid.NewGuid(), Code = 1, Name = "أعزب" },
                new MartialStatusCode { Id = Guid.NewGuid(), Code = 2, Name = "متزوج/ة" },
                new MartialStatusCode { Id = Guid.NewGuid(), Code = 3, Name = "مطلق/ة" },
                new MartialStatusCode { Id = Guid.NewGuid(), Code = 4, Name = "أرمل/ة" }
                );
        }
    }
}
