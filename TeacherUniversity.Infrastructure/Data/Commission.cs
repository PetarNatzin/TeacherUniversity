using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherUniversity.Infrastructure.Data
{
    public class Commission
    {
        [Key]
        public int Id { get; set; }

        public IList<Lecturer> Candidatures { get; set; } = new List<Lecturer>();
    }
}
