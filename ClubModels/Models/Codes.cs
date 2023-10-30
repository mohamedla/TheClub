using ClubModels.Models.GeneralCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models
{
    public abstract class Codes
    {
        public abstract Guid Id { get; set; }

        [Required(ErrorMessage = "Employee Code Is Required Field"), Range(minimum:1, maximum:int.MaxValue, ErrorMessage = "Code must be greater than 0")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Global Name Is Required Field"), Column(TypeName = "NVARCHAR"),
            MaxLength(100, ErrorMessage = "Maximum length for the Global Name is 100 characters")]
        public string Name { get; set; }

        public abstract Codes Clone();
    }
}
