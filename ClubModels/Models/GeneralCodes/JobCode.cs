using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    public class JobCode : Codes
    {
        [Key, Column("JobId")]
        public override Guid Id { get; set; }

        public override JobCode Clone()
            => new JobCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
