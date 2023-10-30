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
    public class TransferCodesConfiguration : IEntityTypeConfiguration<TransferCode>
    {
        public void Configure(EntityTypeBuilder<TransferCode> builder)
        {
            builder.HasData(
                new TransferCode { Id = Guid.NewGuid(), Code = 1, Name = "بلوغ السن القانونية" },
                new TransferCode { Id = Guid.NewGuid(), Code = 2, Name = "الزواج" },
                new TransferCode { Id = Guid.NewGuid(), Code = 3, Name = "الطلاق" },
                new TransferCode { Id = Guid.NewGuid(), Code = 4, Name = "الوفاة" },
                new TransferCode { Id = Guid.NewGuid(), Code = 5, Name = "التخرج" },
                new TransferCode { Id = Guid.NewGuid(), Code = 6, Name = "بناء على رغبة صاحب العضوية" },
                new TransferCode { Id = Guid.NewGuid(), Code = 7, Name = "طبقاً للائحه" }
                );
        }
    }
}
