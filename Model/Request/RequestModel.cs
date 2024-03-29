﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingPracticalTest.Model.Request
{
    public class RequestModel //: IValidatableObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="Ip address or domain is required.")]
        public string Address { get; set; }

        public List<string> Services { get; set; }
    }
}
