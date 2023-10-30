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
    public class MembershipCodesConfiguration : IEntityTypeConfiguration<MembershipCode>
    {
        public void Configure(EntityTypeBuilder<MembershipCode> builder)
        {
            builder.HasData(

                new MembershipCode { Id = Guid.NewGuid(), Code = 1, Name = "عضو عامل" },
                new MembershipCode { Id = Guid.NewGuid(), Code = 10, Name = "عضو زائر" },
                new MembershipCode { Id = Guid.NewGuid(), Code = 3, Name = "عضوية فخرية" },
                new MembershipCode { Id = Guid.NewGuid(), Code = 9, Name = "عضو زائر  (مؤقت)" },
                new MembershipCode { Id = Guid.NewGuid(), Code = 8, Name = "عضويه موسمية" },
                new MembershipCode { Id = Guid.NewGuid(), Code = 2, Name = "عضو عامل خ" }
                );
        }
    }
}
