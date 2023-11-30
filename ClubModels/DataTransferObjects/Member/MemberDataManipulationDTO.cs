﻿using ClubModels.Models.GeneralCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubEntities.DataTransferObjects.Member
{
    public class MemberDataManipulationDTO
    {
        // Personal Data
        [Required(ErrorMessage = "Member Name Is Required"), MaxLength(200, ErrorMessage = "Member Name Has Maximum Length of 200 Chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Member Address Is Required"), StringLength(500, MinimumLength = 20, ErrorMessage = "Member String Must be Between 20 to 500 Chars")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Member City Is Required")]
        public Guid CityId { get; set; }

        [Required(ErrorMessage = "Member Birthday Is Required")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Member Birth Place Is Required")]
        public Guid BirthPlaceId { get; set; }

        [Required(ErrorMessage = "Member Id Number Is Required"), RegularExpression("[0-9]{14}")]
        public string IdNo { get; set; }


        [Required(ErrorMessage = "Member Martial Status Required")]
        public Guid MartialStatusId { get; set; }

        [Required(ErrorMessage = "Nationality Is Required")]
        public Guid NationalityID { get; set; }

        [MaxLength(500)]
        public string Pic { get; set; } // Pic URL

        [Required(ErrorMessage = "Religion Is Required")]
        public Guid ReligionId { get; set; }

        [Required(ErrorMessage = "Gender Is Required")]
        public Guid Gender { get; set; }

        [Required(ErrorMessage = "Member Personal Phone Required"), RegularExpression("[0-9]{8,11}")]
        public string PersonalPhone { get; set; }

        [Required(ErrorMessage = "Member Title Required")]
        public Guid Title { get; set; }

        [Required(ErrorMessage = "Member Job Is Required")]
        public Guid JobId { get; set; }

        [StringLength(500, ErrorMessage = "Member String Must be Between 20 to 500 Chars")]
        public string JobAddress { get; set; } = "";

        [Required(ErrorMessage = "Member Job Phone Required"), RegularExpression("[0-9]{8,11}")]
        public string JobPhone { get; set; }

        // Membership Data
        [Required(ErrorMessage = "Membership Code Is Required")]
        public Guid MembershipId { get; set; }

        [Required(ErrorMessage = "Member Number Required")]
        public int MemberNo { get; set; } // auto generated by mac one +1 or auto generated

        [Required(ErrorMessage = "Member Section Is Required")]
        public Guid SectionId { get; set; }

        [Required(ErrorMessage = "Member End Date Is Required")]
        public DateTime MemberEndDate { get; set; }

        [Required(ErrorMessage = "Member Order Date Is Required")]
        public DateTime MemberOrderDate { get; set; }

        [Required(ErrorMessage = "Member Order Number Required"), RegularExpression("[0-9]")]
        public string MemberOrderNo { get; set; }

        [Required(ErrorMessage = "Member Renew Date Is Required")]
        public DateTime MemberRenewDate { get; set; }


        [Required(ErrorMessage = "Member Qualification Is Required")]
        public Guid QualId { get; set; }

        public bool HasCard { get; set; } = false;

        public DateTime CardDate { get; set; } = DateTime.MinValue;

        [MaxLength(50, ErrorMessage = "Member MSCode Has Maximum Chars of 50"), RegularExpression("[0-9]")]
        public string MSCode { get; set; } = "0";

        public string M_Lock { get; set; } = "";

        public int F_Lock { get; set; } = 0;

        public int TMPFLG { get; set; } = 0;

        [MaxLength(1000, ErrorMessage = "Member Notes Has Maximum Chars of 1000")]
        public string Notes { get; set; } = "";


        [Required(ErrorMessage = "No User Assigned")]
        public string UserName { get; set; } // The User That Add The Data
    }
}