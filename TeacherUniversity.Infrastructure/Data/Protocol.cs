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
    public class Protocol
    {
        [Key]
        public int Id { get; set; }

        public int CommissionId { get; set; }

        [Required]
        [ForeignKey(nameof(CommissionId))]
        public Commission Commission { get; set; }

        [Required]
        public QualificationalDegree QualificationalDegree { get; set; }

        [Required]
        public Subject Subject { get; set; }

        public ICollection<Candidature> Candidatures { get; set; } = new List<Candidature>();
    }
}
