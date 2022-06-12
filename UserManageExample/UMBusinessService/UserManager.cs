using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMCommon.ViewModel;
using UMRepository;
using UMRepository.Entities;

namespace UMBusinessService
{
    public interface IUserManager
    {
        List<User> GetFemalesBelow25();
        List<User> GetMaleAbove40();
        User GetYoungestMale();
        List<User> GetAllAdminManagerFemale();
        List<User> GetAllManagersNameStartsJo();
        string ExportUserData();
    }
    public class UserManager : IUserManager
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
        /// <summary>
        /// Get all Female Users who is having Manager and Admin Roles
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllAdminManagerFemale()
        {
            return _userRepository.GetAllAdminManagerFemale();
        }
        /// <summary>
        /// Get all managers name starts with Jo
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllManagersNameStartsJo()
        {
            return _userRepository.GetAllManagersNameStartsJo();
        }
        /// <summary>
        /// Export User Data
        /// </summary>
        /// <returns></returns>
        public string ExportUserData()
        {
            var exportData = _userRepository.GetUserExportData();
            var directory = @"\output";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var path = @$"\output\{Guid.NewGuid()}.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            var lines = new List<string>();
            exportData.ForEach(d =>
            {
                lines.Add($"{d.FirstName} {d.LastName} is {d.Age} old. It is a {d.GenderDescription}. He has the following roles ({d.Roles}) ");
                
            });
            File.WriteAllLines(path, lines.ToArray());
           
            return $"File Created {Path.GetFullPath(path)}";
        }
    }
}
