using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubEntities.DataTransferObjects.Member
{
    public class MemberDataDTO : MemberDataManipulationDTO
    {
        public Guid Id { get; set; }
    }
}
