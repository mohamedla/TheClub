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
    public class ReferenceCodesConfiguration : IEntityTypeConfiguration<ReferenceCode>
    {
        public void Configure(EntityTypeBuilder<ReferenceCode> builder)
        {
            builder.HasData(
                new ReferenceCode { Id = Guid.NewGuid(), Code = 1, Name = "والد", ReferenceFee = 15.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 2, Name = "والدة", ReferenceFee = 15.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 3, Name = "زوجة", ReferenceFee = 15.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 4, Name = "زوج", ReferenceFee = 15.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 5, Name = "إبن", ReferenceFee = 10.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 6, Name = "إبن", ReferenceFee = 10.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 7, Name = "بنت", ReferenceFee = 10.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 8, Name = "بنت", ReferenceFee = 10.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 9, Name = "زوجة ثانية", ReferenceFee = 40.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 10, Name = "أخ", ReferenceFee = 0.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 11, Name = "أخت", ReferenceFee = 15.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 12, Name = "أخت مطلقة", ReferenceFee = 15.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 13, Name = "بنت أخ", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 14, Name = "ابن اخت", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 15, Name = "بنت اخت", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 16, Name = "خال", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 17, Name = "خاله", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 18, Name = "عم", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 19, Name = "عمه", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 20, Name = "ابن عم", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 21, Name = "بنت عم", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 22, Name = "ابن خاله", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 23, Name = "بنت خاله", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 24, Name = "حفيد", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 25, Name = "حفيده", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 26, Name = "ابن بالتبنى", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 27, Name = "بنت بالتبنى", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 41, Name = "والد تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 42, Name = "والده تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 43, Name = "زوجه تخفيض", ReferenceFee = 4.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 44, Name = "زوج تخفيض", ReferenceFee = 4.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 45, Name = "ابن فوق ال 16 تخفيض", ReferenceFee = 3.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 46, Name = "ابن تحت ال 16 تخفيض", ReferenceFee = 1.5M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 47, Name = "بنت فوق الـ 16 تخفيض", ReferenceFee = 3.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 48, Name = "بنت تحت الـ 16 تخفيض", ReferenceFee = 1.5M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 49, Name = "زوجه ثانيه تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 50, Name = "اخ تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 51, Name = "اخت تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 52, Name = "ابن اخ تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 53, Name = "بنت اخ تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 54, Name = "ابن اخت تخفيض", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 55, Name = "بنت اخت تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 56, Name = "خال تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 57, Name = "خاله تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 58, Name = "عم تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 59, Name = "عمه تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 60, Name = "ابن عم تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 61, Name = "بنت عم تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 62, Name = "ابن خاله تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 63, Name = "بنت خاله تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 64, Name = "حفيد تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 65, Name = "حفيده تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 66, Name = "ابن بالتبنى تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 67, Name = "بنت بالتبنى تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 68, Name = "زوجه عضو فوق ال 60", ReferenceFee = 2.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 69, Name = "زوج عضوه فوق ال 60", ReferenceFee = 2.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 70, Name = "زوجه محاربين قدماء", ReferenceFee = 0.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 28, Name = "ابن الزوجه تحت 16", ReferenceFee = 3.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 29, Name = "ابن الزوجه فوق ال 16", ReferenceFee = 6.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 30, Name = "ابن الزوج تحت ال 16", ReferenceFee = 3.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 31, Name = "ابن الزوج فوق ال 16", ReferenceFee = 6.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 32, Name = "بنت الزوجه تحت 16", ReferenceFee = 3.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 33, Name = "بنت الزوجه فوق 16", ReferenceFee = 6.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 34, Name = "بنت الزوج تحت ال 16", ReferenceFee = 3.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 35, Name = "بنت الزوج فوق ال 16", ReferenceFee = 6.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 71, Name = "ابن الزوجه تحت الـ 16 تخفيض", ReferenceFee = 1.5M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 72, Name = "ابن الزوجه فوق الـ 16 تخفيض", ReferenceFee = 3.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 73, Name = "ابن الزوج تحت 16 تخفيض", ReferenceFee = 1.5M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 74, Name = "ابن الزوج فوق 16 تخفيض", ReferenceFee = 3.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 75, Name = "بنت الزوجه تحت الـ 16 تخفيض", ReferenceFee = 1.5M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 76, Name = "بنت الزوجه فوق الـ 16 تخفيض", ReferenceFee = 3.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 77, Name = "بنت الزوج تحت 16 تخفيض", ReferenceFee = 1.5M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 78, Name = "بنت الزوج فوق ال 16 تخفيض", ReferenceFee = 3.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 79, Name = "زوجه شباب ورياضه", ReferenceFee = 0.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 36, Name = "اخو الزوجه", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 37, Name = "اخت الزوجه", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 38, Name = "اخ الزوج", ReferenceFee = 22.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 39, Name = "اخت الزوج", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 80, Name = "أخ الزوجه تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 81, Name = "اخت الزوجه تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 82, Name = "اخ الزوج تخفيض", ReferenceFee = 11.0M, AgeFlag = true },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 83, Name = "اخت الزوج تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 84, Name = "زوج عضوه شباب ورياضه", ReferenceFee = 0.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 40, Name = "ابن فوق 25 سنه استثناء", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 85, Name = "ابنه فوق 25 سنة استثناء", ReferenceFee = 22.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 86, Name = "ابن فوق ال 25 استثناء تخفيض", ReferenceFee = 11.0M, AgeFlag = false },
                new ReferenceCode { Id = Guid.NewGuid(), Code = 87, Name = "ابنه فوق ال 25 استثناء تخفيض", ReferenceFee = 11.0M, AgeFlag = false }
                );
        }
    }
}
