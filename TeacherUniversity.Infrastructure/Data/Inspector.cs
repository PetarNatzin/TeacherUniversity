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
    public class Inspector
    {
        [Key]
        public int Id { get; set; }

        public string IdentityUserId { get; set; }

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
        public AdministrationDepartment AdministrationDepartment { get; set; }

        [Required]
        public AdministrationStatus AdministrationStatus { get; set; }
    }
}
