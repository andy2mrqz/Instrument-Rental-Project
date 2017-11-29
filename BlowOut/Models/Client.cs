using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlowOut.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int clientID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public String firstname { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public String lastname { get; set; }

        [Required]
        [Display(Name = "Address")]
        public String address { get; set; }

        [Required]
        [Display(Name = "City")]
        public String city { get; set; }

        [Required]
        [Display(Name = "State")]
        [StringLength(2, ErrorMessage = "Please Enter State Abbreviation")]
        public String state { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [StringLength(5)]
        public String zip { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        //[RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        //    ErrorMessage = "Please Enter Correct Email Address")]
        [EmailAddress]
        public String email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(\d{3}\)\s\d{3}\-\d{4}", ErrorMessage = "Invalid Phone Number, e.g. (xxx) xxx-xxx")]
        public String phone { get; set; }
    }
}