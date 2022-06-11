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
    }
}
