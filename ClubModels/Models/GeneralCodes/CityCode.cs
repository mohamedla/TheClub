using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    public class CityCode : Codes, ICodes<CityCode>
    {
        [Key, Column("CityId")]
        public override Guid Id { get; set; }

        public override CityCode Clone()
            => new CityCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
