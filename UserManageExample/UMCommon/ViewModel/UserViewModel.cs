using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMCommon.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Roles { get; set; }
        public string GenderDescription { get
            {
                if (this.Gender.Equals("Male"))
                    return "Man";
                else
                    return "Woman";
            } }
    }
}
