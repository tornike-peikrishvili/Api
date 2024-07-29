using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gamocda.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Surname { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string PersonalNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int CountryId { get; set; }
        public int CityId { get; set; }

        [StringLength(50, MinimumLength = 4)]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}