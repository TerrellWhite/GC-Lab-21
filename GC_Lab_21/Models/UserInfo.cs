using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestASPAppJuly2018.Models
{
    public class UserInfo
    {
        [Required]//attributes
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }
        [Required]
        [RegularExpression("^.{2,}[@].{2,}[.][a-zA-Z]{2,3}$")]
        public string Email { set; get; }
        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string Password { set; get; }
        [Required]
        [RegularExpression("^[0-9]{3}-[0-9]{3}-[0-9]{4}$")]
        public string Phone { set; get; }
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
            Phone = "";
        }
        public UserInfo(string fn, string ln, string em, string ps, string ph)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            Password = ps;
            Phone = ph;
        }
    }
}