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
    public class TitleCodesConfiguration : IEntityTypeConfiguration<TitleCode>
    {
        public void Configure(EntityTypeBuilder<TitleCode> builder)
        {
            builder.HasData(

                new TitleCode { Id = Guid.NewGuid(), Code = 1, Name = "السيد/ة" },
                new TitleCode { Id = Guid.NewGuid(), Code = 2, Name = "أستاذ/ة" },
                new TitleCode { Id = Guid.NewGuid(), Code = 3, Name = "دكتور/ة" }
                );
        }
    }
}
