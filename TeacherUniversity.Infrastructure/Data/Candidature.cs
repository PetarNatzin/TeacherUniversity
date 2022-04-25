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
    public class Candidature
    {
        [Key]
        public int Id { get; set; }

        public int TeacherId { get; set; }

        [Required]
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime CandidatureDate { get; set; } = DateTime.Today;

        [Required]
        public QualificationalDegree QualificationalDegree { get; set; }

        [Required]
        public Subject Subject { get; set; }

        [Required]
        public CandidatureStatus Status { get; set; } = CandidatureStatus.Awaiting;

        public CandidatureScore CandidatureScore { get; set; }
    }
}
