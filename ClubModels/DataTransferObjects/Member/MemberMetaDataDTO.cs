using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubEntities.DataTransferObjects.Member
{
    public class MemberMetaDataDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Global Name Is Required Field"),
            MaxLength(100, ErrorMessage = "Maximum length for the Global Name is 100 characters")]
        public string Title { get; set; }

        public int MemberNo { get; set; }

        [Required(ErrorMessage = "Member Name Is Required"), MaxLength(200, ErrorMessage = "Member Name Has Maximum Length of 200 Chars")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Member Id Number Is Required"), RegularExpression("[0-9]{14}")]
        public string IdNo { get; set; }
    }
}
