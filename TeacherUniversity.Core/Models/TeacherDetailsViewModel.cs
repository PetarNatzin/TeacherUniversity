using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherUniversity.Core.Models
{
    public  class TeacherDetailsViewModel
    {
        public int Id { get; set; }

        public string IdentityUserId { get; set; }
                
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Second Name")]
        public string? SecondName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Personal Identifier Number")]
        public string PersonalIdentifierNumber { get; set; }
                
        [Display(Name = "Gradudated University")]
        public string GradudatedUniversity { get; set; }

        [Display(Name = "Higher Education Degree")]
        public int HigherEducationDegree { get; set; }

        [Display(Name = "Diploma Data")]
        public string DiplomaData { get; set; }

        [Display(Name = "Place Of Work")]
        public string PlaceOfWork { get; set; }

        [Display(Name = "Position At Work")]
        public string PositionAtWork { get; set; }

        [Display(Name = "Personal Address")]
        public string PersonalAddress { get; set; }

        [Display(Name = "Personal Phone Number")]
        public string PersonalPhoneNumber { get; set; }
    }
}
