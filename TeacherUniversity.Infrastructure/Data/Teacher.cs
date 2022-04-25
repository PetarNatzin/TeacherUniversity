using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherUniversity.Infrastructure.Data.Common.Enums;

namespace TeacherUniversity.Infrastructure.Data
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        public int IdentityUserId { get; set; }

        [Required]
        [ForeignKey(nameof(IdentityUserId))]
        public IdentityUser IdentityUser { get; set; }

        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string? SecondName { get; set; }

        [Required]
        [StringLength(200)]
        public string LastName { get; set; }

        [Required]       
        [StringLength(20)]
        public string PersonalIdentifierNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string GradudatedUniversity { get; set; }

        [Required]       
        public HigherEducationDegree HigherEducationDegree { get; set; }

        [Required]
        [StringLength(20)]
        public string DiplomaData { get; set; }

        [Required]
        [StringLength(30)]
        public string PlaceOfWork { get; set; }

        [Required]
        [StringLength(30)]
        public string PositionAtWork { get; set; }

        [Required]
        [StringLength(30)]
        public string PersonalAddress { get; set; }

        [Required]
        [StringLength(30)]
        public string PersonalPhoneNumber { get; set; }
    }
}
