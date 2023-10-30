using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels.Models.GeneralCodes
{
    public class SectionCode : Codes
    {
        [Key, Column("SectionId")]
        public override Guid Id { get; set; }

        [Required(ErrorMessage = "The Annual Is Required")]
        public bool Annual { get; set; } = false;

        [Required(ErrorMessage = "The Improve Is Required")]
        public bool Improve { get; set; } = false;

        [Required(ErrorMessage = "The Id Is Required"), Column("Id")]
        public bool IsId { get; set; } = false;

        [Required(ErrorMessage = "The Init Is Required")]
        public bool Init { get; set; } = false;

        [Required(ErrorMessage = "The Office Is Required")]
        public bool Office { get; set; } = false;

        [Required(ErrorMessage = "The Penalty Is Required")]
        public bool Penalty { get; set; } = false;

        [Required(ErrorMessage = "The Player Is Required")]
        public bool Player { get; set; } = false;

        [Required(ErrorMessage = "The Pool Is Required")]
        public bool Pool { get; set; } = false;

        [Required(ErrorMessage = "The Post Is Required")]
        public bool Post { get; set; } = false;

        [Required(ErrorMessage = "The Reg Is Required")]
        public bool Reg { get; set; } = false;

        [Required(ErrorMessage = "The River Is Required")]
        public bool River { get; set; } = false;

        [Required(ErrorMessage = "The Stamp Is Required")]
        public bool Stamp { get; set; } = false;

        [Required(ErrorMessage = "The Worker Is Required")]
        public bool Worker { get; set; } = false;

        [Required(ErrorMessage = "The Donation Is Required")]
        public bool Donation { get; set; } = false;

        [Required(ErrorMessage = "The Maintenance Is Required")]
        public bool Maintenance { get; set; } = false;

        [Required(ErrorMessage = "The Society Is Required")]
        public bool Society { get; set; } = false;

        [Required(ErrorMessage = "The Com Penalty Is Required")]
        public bool ComPenalty { get; set; } = false;

        [Required(ErrorMessage = "The Reserve Fee Is Required")]
        public bool ReserveFee { get; set; } = false;
        public override SectionCode Clone()
            => new SectionCode
            {
                Id = this.Id,
                Name = this.Name,
                Code = this.Code,
                Annual = this.Annual,
                Improve = this.Improve,
                IsId = this.IsId,
                Init = this.Init,
                Office = this.Office,
                Penalty = this.Penalty,
                Pool = this.Pool,
                Post = this.Post,
                Reg = this.Reg,
                River = this.River,
                Stamp = this.Stamp,
                Worker = this.Worker,
                ComPenalty = this.ComPenalty,
                ReserveFee = this.ReserveFee,
                Donation = this.Donation,
                Maintenance = this.Maintenance,
                Player = this.Player,
                Society = this.Society
            };
    }
}
