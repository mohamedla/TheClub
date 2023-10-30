using ClubModels.Models.GeneralCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubEntities.DataTransferObjects
{
    public abstract class Codes
    {
        public int Code { get; set; }

        [Required(ErrorMessage = "Global Name Is Required Field"), Column(TypeName = "NVARCHAR"),
            MaxLength(100, ErrorMessage = "Maximum length for the Global Name is 100 characters")]
        public string Name { get; set; }
    }
}
