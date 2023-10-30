using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    [Table("TransCodes")]
    public class TransferCode : Codes
    {
        [Key, Column("TransId")]
        public override Guid Id { get; set; }

        public override TransferCode Clone()
            => new TransferCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
