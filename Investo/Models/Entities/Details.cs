using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Investo.Models.Entities
{
    public abstract class Details : BaseEntity
    {

        [Required]
        public string FirstName { get; set; }


        public string MiddleName { get; set; }


        [Required]
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
    }


}
