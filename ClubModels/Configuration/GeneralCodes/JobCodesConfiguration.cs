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
    public class JobCodesConfiguration : IEntityTypeConfiguration<JobCode>
    {
        public void Configure(EntityTypeBuilder<JobCode> builder)
        {
            builder.HasData(
                new JobCode { Id = Guid.NewGuid(), Code = 389, Name = "مساعد قائد قطار" },
                new JobCode { Id = Guid.NewGuid(), Code = 396, Name = "قائد قطار" },
                new JobCode { Id = Guid.NewGuid(), Code = 267, Name = "رئيس قطار" },
                new JobCode { Id = Guid.NewGuid(), Code = 4, Name = "معاش" },
                new JobCode { Id = Guid.NewGuid(), Code = 5, Name = "محاسب" },
                new JobCode { Id = Guid.NewGuid(), Code = 6, Name = "مهندس" },
                new JobCode { Id = Guid.NewGuid(), Code = 7, Name = "دكتور" },
                new JobCode { Id = Guid.NewGuid(), Code = 1, Name = "المالية" },
                new JobCode { Id = Guid.NewGuid(), Code = 2, Name = "الموارد البشريه" },
                new JobCode { Id = Guid.NewGuid(), Code = 3, Name = "قطاع البضائع" },
                new JobCode { Id = Guid.NewGuid(), Code = 20, Name = "ميكانيكى" },
                new JobCode { Id = Guid.NewGuid(), Code = 21, Name = "خراط" },
                new JobCode { Id = Guid.NewGuid(), Code = 30, Name = "ملاحظ" },
                new JobCode { Id = Guid.NewGuid(), Code = 23, Name = "فنى" },
                new JobCode { Id = Guid.NewGuid(), Code = 26, Name = "ملاحظ" },
                new JobCode { Id = Guid.NewGuid(), Code = 50, Name = "سائق" },
                new JobCode { Id = Guid.NewGuid(), Code = 51, Name = "كهربائي" },
                new JobCode { Id = Guid.NewGuid(), Code = 52, Name = "نقاش" },
                new JobCode { Id = Guid.NewGuid(), Code = 53, Name = "سباك" },
                new JobCode { Id = Guid.NewGuid(), Code = 54, Name = "نجار" },
                new JobCode { Id = Guid.NewGuid(), Code = 55, Name = "لحام" },
                new JobCode { Id = Guid.NewGuid(), Code = 56, Name = "صراف تذاكر" },
                new JobCode { Id = Guid.NewGuid(), Code = 57, Name = "تمريض" },
                new JobCode { Id = Guid.NewGuid(), Code = 58, Name = "موظف" },
                new JobCode { Id = Guid.NewGuid(), Code = 59, Name = "مشرف قطار" },
                new JobCode { Id = Guid.NewGuid(), Code = 60, Name = "ناظر محطه" },
                new JobCode { Id = Guid.NewGuid(), Code = 61, Name = "فحص مالى" },
                new JobCode { Id = Guid.NewGuid(), Code = 100, Name = "كاتب" },
                new JobCode { Id = Guid.NewGuid(), Code = 101, Name = "مدير عام" },
                new JobCode { Id = Guid.NewGuid(), Code = 103, Name = "اشارات مصر" },
                new JobCode { Id = Guid.NewGuid(), Code = 104, Name = "هندسة الاشارات" },
                new JobCode { Id = Guid.NewGuid(), Code = 106, Name = "كاتبة" },
                new JobCode { Id = Guid.NewGuid(), Code = 107, Name = "كاتبة" },
                new JobCode { Id = Guid.NewGuid(), Code = 109, Name = "رئيس قسم" },
                new JobCode { Id = Guid.NewGuid(), Code = 110, Name = "براد" },
                new JobCode { Id = Guid.NewGuid(), Code = 121, Name = "بناء افران" },
                new JobCode { Id = Guid.NewGuid(), Code = 180, Name = "عامل" },
                new JobCode { Id = Guid.NewGuid(), Code = 157, Name = "حداد" },
                new JobCode { Id = Guid.NewGuid(), Code = 158, Name = "حرفى" },
                new JobCode { Id = Guid.NewGuid(), Code = 200, Name = "مراقب ابراج" },
                new JobCode { Id = Guid.NewGuid(), Code = 201, Name = "سروجى" },
                new JobCode { Id = Guid.NewGuid(), Code = 202, Name = "مضيف قطار" },
                new JobCode { Id = Guid.NewGuid(), Code = 203, Name = "طباع" },
                new JobCode { Id = Guid.NewGuid(), Code = 102, Name = "امين مخزن" },
                new JobCode { Id = Guid.NewGuid(), Code = 0, Name = "خدمات معاونه" },
                new JobCode { Id = Guid.NewGuid(), Code = 500, Name = "مفتش" },
                new JobCode { Id = Guid.NewGuid(), Code = 400, Name = "مدير ادارة" },
                new JobCode { Id = Guid.NewGuid(), Code = 401, Name = "محقق قانوني" },
                new JobCode { Id = Guid.NewGuid(), Code = 402, Name = "نائب رئيس مجلس الاداره" },
                new JobCode { Id = Guid.NewGuid(), Code = 403, Name = "رئيس إدارة مركزية" },
                new JobCode { Id = Guid.NewGuid(), Code = 70, Name = "مراقب" },
                new JobCode { Id = Guid.NewGuid(), Code = 80, Name = "أخرى" },
                new JobCode { Id = Guid.NewGuid(), Code = 81, Name = "ن . مالية" },
                new JobCode { Id = Guid.NewGuid(), Code = 111, Name = "رئيس حركه" },
                new JobCode { Id = Guid.NewGuid(), Code = 300, Name = "اداري" },
                new JobCode { Id = Guid.NewGuid(), Code = 301, Name = "محامي" }
                );
        }
    }
}
