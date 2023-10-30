using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    public class GenderCode : Codes
    {

        [Key, Column("GenderId")]
        public override Guid Id { get; set; }

        public override GenderCode Clone()
            => new GenderCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
