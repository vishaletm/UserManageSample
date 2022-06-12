using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMCommon.ViewModel;
using UMRepository.Entities;

namespace UMRepository
{
    public interface IUserRepository
    {
        List<User> GetFemalesBelow25();
        List<User> GetMaleAbove40();
        User GetYoungestMale();
        List<User> GetAllAdminManagerFemale();
        List<User> GetAllManagersNameStartsJo();
        List<UserViewModel> GetUserExportData();
    }
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Get Female Users below 25
        /// </summary>
        /// <returns></returns>
        public List<User> GetFemalesBelow25()
        {
            var users = UserContext.Users.Where(u => u.Gender.Equals("Female") && u.Age < 25);

            return users.ToList();
        }
        /// <summary>
        /// Get Male Users above 40
        /// </summary>
        /// <returns></returns>
        public List<User> GetMaleAbove40()
        {
            var users = UserContext.Users.Where(u => u.Gender.Equals("Male") && u.Age >40);

            return users.ToList();

        }
        public User GetYoungestMale()
        {
            var user = UserContext.Users.Where(u => u.Gender.Equals("Male")).OrderBy(u=>u.Age).FirstOrDefault();

            return user;

        }
        /// <summary>
        /// Get all Female Users who is having Manager and Admin Roles
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllAdminManagerFemale()
        {
            var users = UserContext.Users.Where(u => u.Gender.Equals("Female"))
                .Join(UserContext.UserRoles, user => user.Id, userRoles => userRoles.UserId, (user, userRole) => new { user, userRole })
                .Join(UserContext.Roles.Where(r => r.Name == "Manager" || r.Name == "Admin"), userData => userData.userRole.RoleId, role => role.Id, (userData, role) => new { userData.user })
                .Select(u=>u.user)
                .GroupBy(u => u.Id).Select(group => group.First())
                .ToList();
            return users;

        }
        /// <summary>
        /// Get all Managers with Name Starts with Jo
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllManagersNameStartsJo()
        {
            var users = UserContext.Users.Where(u => u.FirstName.StartsWith("Jo"))
                .Join(UserContext.UserRoles, user => user.Id, userRoles => userRoles.UserId, (user, userRole) => new { user, userRole })
                .Join(UserContext.Roles.Where(r => r.Name == "Manager"), userData => userData.userRole.RoleId, role => role.Id, (userData, role) => new { userData.user })
                .Select(u => u.user)
                .ToList();
            return users;

        }
        /// <summary>
        /// Get Data for user export
        /// </summary>
        /// <returns></returns>
        public List<UserViewModel> GetUserExportData()
        {
            var users = new List<UserViewModel>();
            UserContext.Users.ForEach(u =>
            {
                var roles = UserContext.UserRoles.Where(r => r.UserId == u.Id)
                 .Join(UserContext.Roles, ur => ur.RoleId, role => role.Id, (ur, role) => new { role })
                 .Select(r => r.role.Name);
                users.Add(new UserViewModel
                {
                    Age = u.Age,
                    FirstName = u.FirstName,
                    Gender = u.Gender,
                    Id = u.Id,
                    LastName = u.LastName,
                    Roles = String.Join(',', roles.ToArray())

                });
            });
            return users;

        }

    }
}
