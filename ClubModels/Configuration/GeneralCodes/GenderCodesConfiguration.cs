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
    public class GenderCodesConfiguration : IEntityTypeConfiguration<GenderCode>
    {
        public void Configure(EntityTypeBuilder<GenderCode> builder)
        {
            builder.HasData(

                new GenderCode { Id = Guid.NewGuid(), Code = 1, Name = "ذكر" },
                new GenderCode { Id = Guid.NewGuid(), Code = 2, Name = "أنثى" },
                new GenderCode { Id = Guid.NewGuid(), Code = 3, Name = "غير معروف" }
                );
        }
    }
}
