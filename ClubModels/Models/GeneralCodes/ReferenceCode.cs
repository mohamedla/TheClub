using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    [Table("RefCodes")]
    public class ReferenceCode : Codes
    {
        [Key, Column("RefId")]
        public override Guid Id { get; set; }

        [Required(ErrorMessage = "The Reference Fees Is Required"), Column(name:"RefFee")]
        public decimal ReferenceFee { get; set; }

        [Required(ErrorMessage = "The Age Flag Is Required")]
        public bool AgeFlag { get; set; } = false;

        public override ReferenceCode Clone()
            => new ReferenceCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code,
                ReferenceFee = this.ReferenceFee,
                AgeFlag = this.AgeFlag
            };
    }
}
