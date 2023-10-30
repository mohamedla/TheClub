using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    [Table("QualCodes")]
    public class QualificationCode : Codes
    {
        [Key, Column("QualId")]
        public override Guid Id { get; set; }

        public override QualificationCode Clone()
            => new QualificationCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
