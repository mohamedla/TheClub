using ClubEntities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubEntities.DataTransferObjects.NationalityCodes
{
    public class NationalityCodeDTO : Codes
    {
        public Guid Id { get; set; }
    }
}
