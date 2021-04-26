using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Investo.Models.Entities
{
    public abstract class Details : BaseEntity
    {

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }


        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }


        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }



        [Required]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Email is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [MaxLength(72)]
        public string Password { get; set; }

        [DisplayName("Home Address")]
        public string Address { get; set; }


        [DisplayName("Phone Number")]
        [Required]
        public int PhoneNumber { get; set; }



    }


}
