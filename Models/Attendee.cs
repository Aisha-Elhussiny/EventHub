using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventHub.Models
{
    public class Attendee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Street { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        //elesm f el database hyb2a kda 
        public string PostalCode { get; set; }

        [NotMapped]
        //3shan mn3mlsh column f eldatabase 
        public string FullAddress
        {
            get
            {
                return Street + ", " + City + ", "
                    + Country + ", " + PostalCode;
            }
        }

        public Badge? Badge { get; set; }
    }
}
