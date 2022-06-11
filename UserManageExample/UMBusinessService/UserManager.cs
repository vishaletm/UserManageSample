using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMRepository;
using UMRepository.Entities;

namespace UMBusinessService
{
    public interface IUserManager
    {
        List<User> GetFemalesBelow25();
        List<User> GetMaleAbove40();
        User GetYoungestMale();
    }
    public class UserManager: IUserManager
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetFemalesBelow25()
        {
            return _userRepository.GetFemalesBelow25();
        }
        public List<User> GetMaleAbove40()
        {
            return _userRepository.GetMaleAbove40();
        }
        public User GetYoungestMale()
        {
            return _userRepository.GetYoungestMale();
        }
    }
}
