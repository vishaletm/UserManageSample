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
    }
    public class UserRepository:IUserRepository
    {

        public List<User> GetFemalesBelow25()
        {
            var users = UserContext.Users.Where(u => u.Gender.Equals("Female") && u.Age < 25);

            return users.ToList();
                
        }
    }
}
