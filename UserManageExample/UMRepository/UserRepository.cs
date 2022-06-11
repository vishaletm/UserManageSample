using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMRepository.Entities;

namespace UMRepository
{
    public interface IUserRepository
    {
        List<User> GetFemalesBelow25();
        List<User> GetMaleAbove40();
        User GetYoungestMale();
    }
    public class UserRepository : IUserRepository
    {

        public List<User> GetFemalesBelow25()
        {
            var users = UserContext.Users.Where(u => u.Gender.Equals("Female") && u.Age < 25);

            return users.ToList();
        }

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
    }
}
