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
    public class CityCodesConfiguration : IEntityTypeConfiguration<CityCode>
    {
        public void Configure(EntityTypeBuilder<CityCode> builder)
        {
            builder.HasData(

                new CityCode { Id = Guid.NewGuid(), Code = 1, Name = "القاهرة" },
                new CityCode { Id = Guid.NewGuid(), Code = 2, Name = "الجيزة" },
                new CityCode { Id = Guid.NewGuid(), Code = 3, Name = "البحيرة" },
                new CityCode { Id = Guid.NewGuid(), Code = 4, Name = "الشرقية" },
                new CityCode { Id = Guid.NewGuid(), Code = 5, Name = "المنوفية" },
                new CityCode { Id = Guid.NewGuid(), Code = 6, Name = "مرسى مطروح" },
                new CityCode { Id = Guid.NewGuid(), Code = 7, Name = "دمياط" },
                new CityCode { Id = Guid.NewGuid(), Code = 8, Name = "امبابه" },
                new CityCode { Id = Guid.NewGuid(), Code = 9, Name = "البساتين" },
                new CityCode { Id = Guid.NewGuid(), Code = 10, Name = "القليوبية" },
                new CityCode { Id = Guid.NewGuid(), Code = 11, Name = "شبرا الخيمه" },
                new CityCode { Id = Guid.NewGuid(), Code = 12, Name = "سوهاج" },
                new CityCode { Id = Guid.NewGuid(), Code = 13, Name = "ميت غمرة" },
                new CityCode { Id = Guid.NewGuid(), Code = 14, Name = "بنى سويف" },
                new CityCode { Id = Guid.NewGuid(), Code = 15, Name = "الفيوم" },
                new CityCode { Id = Guid.NewGuid(), Code = 16, Name = "اسيوط" },
                new CityCode { Id = Guid.NewGuid(), Code = 17, Name = "المنيا" },
                new CityCode { Id = Guid.NewGuid(), Code = 18, Name = "الفيوم" },
                new CityCode { Id = Guid.NewGuid(), Code = 19, Name = "الغربيه" },
                new CityCode { Id = Guid.NewGuid(), Code = 20, Name = "الاسماعلية" },
                new CityCode { Id = Guid.NewGuid(), Code = 21, Name = "الدقهليه" },
                new CityCode { Id = Guid.NewGuid(), Code = 22, Name = "قليوب" },
                new CityCode { Id = Guid.NewGuid(), Code = 23, Name = "بورسعيد" },
                new CityCode { Id = Guid.NewGuid(), Code = 24, Name = "طنطا" },
                new CityCode { Id = Guid.NewGuid(), Code = 25, Name = "الاسكندريه" },
                new CityCode { Id = Guid.NewGuid(), Code = 26, Name = "دمنهور" },
                new CityCode { Id = Guid.NewGuid(), Code = 27, Name = "الوادى الجديد" },
                new CityCode { Id = Guid.NewGuid(), Code = 28, Name = "الاقصر" },
                new CityCode { Id = Guid.NewGuid(), Code = 29, Name = "المحله" },
                new CityCode { Id = Guid.NewGuid(), Code = 30, Name = "كفر الشيخ" },
                new CityCode { Id = Guid.NewGuid(), Code = 31, Name = "المنصوره" },
                new CityCode { Id = Guid.NewGuid(), Code = 32, Name = "قنا" },
                new CityCode { Id = Guid.NewGuid(), Code = 33, Name = "بنها" },
                new CityCode { Id = Guid.NewGuid(), Code = 34, Name = "السويس" },
                new CityCode { Id = Guid.NewGuid(), Code = 35, Name = "اسوان" },
                new CityCode { Id = Guid.NewGuid(), Code = 36, Name = "شبين الكوم" },
                new CityCode { Id = Guid.NewGuid(), Code = 37, Name = "القاهره" },
                new CityCode { Id = Guid.NewGuid(), Code = 38, Name = "طهران" },
                new CityCode { Id = Guid.NewGuid(), Code = 39, Name = "جنوب سيناء" },
                new CityCode { Id = Guid.NewGuid(), Code = 40, Name = "الامارات" },
                new CityCode { Id = Guid.NewGuid(), Code = 41, Name = "البحر الاحمر" },
                new CityCode { Id = Guid.NewGuid(), Code = 42, Name = "القاهرة" }
                );
        }
    }
}
