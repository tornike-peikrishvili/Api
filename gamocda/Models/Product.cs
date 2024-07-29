using gamocda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gamocda.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 100)]
        public string Annotation { get; set; }

        [Required]
        public ProductType ProductType { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string ISBN { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int PublisherId { get; set; }
        public int? NumberOfPages { get; set; }
        public string Address { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}