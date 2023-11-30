using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubEntities.DataTransferObjects.Member
{
    public class MemberDataUpdateDTO : MemberDataManipulationDTO
    {
        public Guid Id { get; set; }
    }
}
