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
    public interface ICodes<T> where T : Codes
    {
        public Guid Id { get; set; }

        public int Code { get; set; }

        public string Name { get; set; }

        public T Clone();
    }
}
