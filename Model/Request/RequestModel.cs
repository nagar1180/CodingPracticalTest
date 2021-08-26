using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingPracticalTest.Model.Request
{
    public class RequestModel //: IValidatableObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="Ip address or domain is required.")]
        public string Address { get; set; }     
    }
}
