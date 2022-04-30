using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherUniversity.Core.Contracts;
using TeacherUniversity.Core.Models;
using TeacherUniversity.Infrastructure.Data;
using TeacherUniversity.Infrastructure.Data.Common.Enums;
using TeacherUniversity.Infrastructure.Data.Repositories;

namespace TeacherUniversity.Core.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IApplicatioDbRepository repo;
        //private readonly UserManager<IdentityUser> userManager;

        public TeacherService(IApplicatioDbRepository _repo) //, UserManager<IdentityUser> _userManager
        {
            repo = _repo;
            //userManager = _userManager;
        }

        public async Task<bool> CreateTeacher(TeacherCreateViewModel model, string userId)
        {
            bool result = false;
            Teacher teacher = new Teacher()
            {
                IdentityUserId = userId,
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                LastName = model.LastName,
                PersonalIdentifierNumber = model.PersonalIdentifierNumber,
                GradudatedUniversity = model.GradudatedUniversity,
                HigherEducationDegree = (HigherEducationDegree)model.HigherEducationDegree,
                DiplomaData = model.DiplomaData,
                PlaceOfWork = model.PlaceOfWork,
                PositionAtWork = model.PositionAtWork,
                PersonalAddress = model.PersonalAddress,
                PersonalPhoneNumber = model.PersonalPhoneNumber
            };

            await repo.AddAsync(teacher);
            await repo.SaveChangesAsync();
            result = true;

            //if (user != null)
            //{
            //    //user.FirstName = model.FirstName;
            //    //user.LastName = model.LastName;

            //    await repo.SaveChangesAsync();
            //    result = true;
            //}

            return result;
        }

        public async Task<IdentityUser> GetIdentityUserId(string id)
        {
            return await repo.GetByIdAsync<IdentityUser>(id);
        }

        public async Task<bool> TeacherCreated(string id)
        {
            bool created = false;

            IQueryable<Teacher> allTeachers = repo.AllReadonly<Teacher>();

            //allTeachers.FirstOrDefault(x => x.IdentityUserId == id);


            //if (allTeachers.Any()) //await repo.AllReadonly<Teacher>()
            //{
            //    created = true;
            //}

            if (allTeachers.FirstOrDefault(x => x.IdentityUserId == id) != null) //await repo.AllReadonly<Teacher>()
            {
                created = true;
            }

            //created = allTeachers.Any(x => x.IdentityUserId == id);

            return created;
        }

        //public async Task<IEnumerable<TeacherDetailsViewModel>> GetTeacher(string id)
        //{
        //    IQueryable<Teacher> allTeachers = repo.AllReadonly<Teacher>();

        //    TeacherDetailsViewModel currentTeacher = allTeachers
        //        .FirstOrDefault(x => x.IdentityUserId == id)
        //        .(u => new TeacherDetailsViewModel()
        //        {
        //            IdentityUserId = u.IdentityUserId,
        //            FirstName = u.FirstName,
        //            LastName = u.LastName,

        //        })

        //    return await allTeachers
        //        .FirstOrDefault(x => x.IdentityUserId == id)
        //        .Select(u => new TeacherDetailsViewModel()
        //        {
        //            Email = u.Email,
        //            Id = u.Id,
        //            Name = $"{u.FirstName} {u.LastName}"
        //        })
        //        .ToListAsync();

        //    return await allTeachers.All<Teacher>()
        //        .Select(u => new TeacherDetailsViewModel()
        //        {

                    
        //        })
        //        .ToListAsync();
        //}
    }
}
