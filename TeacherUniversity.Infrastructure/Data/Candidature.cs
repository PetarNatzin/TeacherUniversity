using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherUniversity.Infrastructure.Data.Common.Enums;

namespace TeacherUniversity.Infrastructure.Data
{
    public class Candidature
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public QualificationalDegree QualificationalDegree { get; set; }

        [Required]
        public Subject Subject { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
