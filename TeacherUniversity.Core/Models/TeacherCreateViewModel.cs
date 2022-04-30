using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherUniversity.Infrastructure.Data.Common.Enums;

namespace TeacherUniversity.Core.Models
{
    public class TeacherCreateViewModel
    {
        public string IdentityUserId { get; set; }                

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Second Name")]
        public string? SecondName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Personal Identifier Number")]
        public string PersonalIdentifierNumber { get; set; }

        [Required]
        [Display(Name = "Gradudated University")]
        public string GradudatedUniversity { get; set; }

        [Required]
        [Display(Name = "Higher Education Degree")]
        public int HigherEducationDegree { get; set; }

        [Required]
        [Display(Name = "Diploma Data")]
        public string DiplomaData { get; set; }

        [Required]
        [Display(Name = "Place Of Work")]
        public string PlaceOfWork { get; set; }

        [Required]
        [Display(Name = "Position At Work")]
        public string PositionAtWork { get; set; }

        [Required]
        [Display(Name = "Personal Address")]
        public string PersonalAddress { get; set; }

        [Required]
        [Display(Name = "Personal Phone Number")]
        public string PersonalPhoneNumber { get; set; }
    }
}
