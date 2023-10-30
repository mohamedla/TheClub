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
    public class QualificationCodesConfiguration : IEntityTypeConfiguration<QualificationCode>
    {
        public void Configure(EntityTypeBuilder<QualificationCode> builder)
        {
            builder.HasData(
                new QualificationCode { Id = Guid.NewGuid(), Code = 1, Name = "مؤهل فوق عالى" },
                new QualificationCode { Id = Guid.NewGuid(), Code = 2, Name = "مؤهل عالى" },
                new QualificationCode { Id = Guid.NewGuid(), Code = 3, Name = "مؤهل فوق المتوسط" },
                new QualificationCode { Id = Guid.NewGuid(), Code = 4, Name = "مؤهل متوسط" },
                new QualificationCode { Id = Guid.NewGuid(), Code = 5, Name = "بدون مؤهل" },
                new QualificationCode { Id = Guid.NewGuid(), Code = 6, Name = "طالب" },
                new QualificationCode { Id = Guid.NewGuid(), Code = 7, Name = "طالبة" },
                new QualificationCode { Id = Guid.NewGuid(), Code = 300, Name = "محامي" }
                );
        }
    }
}
