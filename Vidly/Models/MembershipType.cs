﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {

        public byte Id { get; set; } //membership type
     
        public short SingUpFee { get; set; }
        public byte DurationInMonth { get; set; }

        public byte DiscountRate { get; set; }
        [Required]
        public string Name { get; set; }



    }
}