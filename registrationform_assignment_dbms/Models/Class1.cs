using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace registrationform_assignment_dbms.Models
{
    public class Class1
    {
        
        [Required]
        public string name { get; set; }
        public string email { get; set; }
        public int number { get; set; }
        public int cnic { get; set; }

        public string education { get; set; }
        public string gender { get; set; }
        public string province { get; set; }
        public string city { get; set; }
    }
}