using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherUniversity.Core.Models;

namespace TeacherUniversity.Core.Contracts
{
    public interface ITeacherService
    {
        Task<IdentityUser> GetIdentityUserId(string id);

        Task<bool> CreateTeacher(TeacherCreateViewModel model, string userId);

        Task<bool> TeacherCreated(string id);
    }
}
