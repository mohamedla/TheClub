﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    public class ReligionCode : Codes
    {
        [Key, Column("ReligionId")]
        public override Guid Id { get; set; }

        public virtual IEnumerable<Member>? Members { get; set; }
        public override ReligionCode Clone()
            => new ReligionCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code
            };
    }
}
