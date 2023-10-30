using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    public class NationalityCode : Codes
    {
        [Key, Column("NationalityId")]
        public override Guid Id { get; set; }

        public override NationalityCode Clone()
            => new NationalityCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
