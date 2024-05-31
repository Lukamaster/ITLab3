using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        [StringLength(5)]
        public string PatientCode { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Description { get; set; }

        //public static IEnumerable<Object> Genders = new List<Object> {
        //     new Object {
        //        GenderId = 1,
        //        Name = "Male"
        //     },
        //    new Color {
        //        GenderId = 2,
        //        Name = "Female"
        //    }
        //};
    }
}