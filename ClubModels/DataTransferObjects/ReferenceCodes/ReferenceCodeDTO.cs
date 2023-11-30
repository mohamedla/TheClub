using ClubEntities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubEntities.DataTransferObjects.ReferenceCodes
{
    public class ReferenceCodeDTO : Codes
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Reference Fees Is Required"), Column(name: "RefFee"), Range(minimum: 0D, maximum: (double)decimal.MaxValue)]
        public decimal ReferenceFee { get; set; }

        [Required(ErrorMessage = "The Age Flag Is Required")]
        public bool AgeFlag { get; set; }
    }
}
