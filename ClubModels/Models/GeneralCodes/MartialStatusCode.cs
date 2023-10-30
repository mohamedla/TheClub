using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    public class MartialStatusCode : Codes
    {
        [Key, Column("MartialStatusId")]
        public override Guid Id { get; set; }

        public override MartialStatusCode Clone()
            => new MartialStatusCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
