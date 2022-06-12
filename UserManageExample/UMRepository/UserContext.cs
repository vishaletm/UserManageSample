using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMRepository.Entities;

namespace UMRepository
{
    /// <summary>
    /// Seed Data inserted from here, please ignore data errors like same Id coming in multiple records
    /// </summary>
    public static class UserContext
    {
        public static readonly List<User> Users;
        public static readonly List<Roles> Roles;
        public static readonly List<UserRoles> UserRoles;

        static UserContext()
        {
            Users = new List<User>();
            Roles = new List<Roles>();
            UserRoles = new List<UserRoles>();

            Roles.Add(new Entities.Roles
            {
                Name = "Manager",
                Id = 1,
            });
            Roles.Add(new Entities.Roles
            {
                Name = "Admin",
                Id = 2,
            });
            Roles.Add(new Entities.Roles
            {
                Name = "Employee",
                Id = 3,
            });

            Users.Add(new User
            {
                Id = 1,
                FirstName = "Susan",
                LastName = "Thomas",
                Gender = "Female",
                Age=21
            });
            Users.Add(new User
            {
                Id = 2,
                FirstName = "John",
                LastName = "Michael",
                Gender = "Male",
                Age=34
            });
            Users.Add(new User
            {
                Id = 3,
                FirstName = "Tom",
                LastName = "Muller",
                Gender = "Male",
                Age=27
            });
            Users.Add(new User { FirstName = "Daisy", LastName = "George", Gender = "Female", Age = 23, Id = 6 });
            Users.Add(new User { FirstName = "Deborah", LastName = "Bruce", Gender = "Female", Age = 53, Id = 45 });
            Users.Add(new User { FirstName = "Isabel", LastName = "Christopher", Gender = "Female", Age = 45, Id = 28 });
            Users.Add(new User { FirstName = "Stella", LastName = "Mark", Gender = "Female", Age = 36, Id = 34 });
            Users.Add(new User { FirstName = "Debra", LastName = "Ron", Gender = "Female", Age = 34, Id = 25 });
            Users.Add(new User { FirstName = "Joverly", LastName = "Craig", Gender = "Female", Age = 40, Id = 40 });
            Users.Add(new User { FirstName = "Vera", LastName = "Philip", Gender = "Female", Age = 32, Id = 4 });
            Users.Add(new User { FirstName = "Angela", LastName = "Jimmy", Gender = "Female", Age = 36, Id = 49 });
            Users.Add(new User { FirstName = "Lucy", LastName = "Arthur", Gender = "Female", Age = 45, Id = 26 });
            Users.Add(new User { FirstName = "Lauren", LastName = "Jaime", Gender = "Female", Age = 54, Id = 36 });
            Users.Add(new User { FirstName = "Janet", LastName = "Perry", Gender = "Female", Age = 24, Id = 40 });
            Users.Add(new User { FirstName = "Loretta", LastName = "Harold", Gender = "Female", Age = 29, Id = 46 });
            Users.Add(new User { FirstName = "Tracey", LastName = "Jerry", Gender = "Female", Age = 43, Id = 45 });
            Users.Add(new User { FirstName = "Beatrice", LastName = "Shawn", Gender = "Female", Age = 34, Id = 13 });
            Users.Add(new User { FirstName = "Sabrina", LastName = "Walter", Gender = "Female", Age = 35, Id = 45 });
            Users.Add(new User { FirstName = "Melody", LastName = "Paul", Gender = "Female", Age = 55, Id = 22 });

            Users.Add(new User { FirstName = "Wade", LastName = "Lewis", Gender = "Male", Age = 23, Id = 20 });
            Users.Add(new User { FirstName = "Dave", LastName = "Milton", Gender = "Male", Age = 28, Id = 14 });
            Users.Add(new User { FirstName = "Seth", LastName = "Claude", Gender = "Male", Age = 51, Id = 17 });
            Users.Add(new User { FirstName = "Ivan", LastName = "Joshua", Gender = "Male", Age = 29, Id = 24 });
            Users.Add(new User { FirstName = "Riley", LastName = "Glen", Gender = "Male", Age = 27, Id = 47 });
            Users.Add(new User { FirstName = "Gilbert", LastName = "Harvey", Gender = "Male", Age = 38, Id = 40 });
            Users.Add(new User { FirstName = "Jorge", LastName = "Blake", Gender = "Male", Age = 48, Id = 7 });
            Users.Add(new User { FirstName = "Dan", LastName = "Antonio", Gender = "Male", Age = 42, Id = 33 });
            Users.Add(new User { FirstName = "Brian", LastName = "Connor", Gender = "Male", Age = 23, Id = 28 });
            Users.Add(new User { FirstName = "Roberto", LastName = "Julian", Gender = "Male", Age = 29, Id = 26 });
            Users.Add(new User { FirstName = "Ramon", LastName = "Aidan", Gender = "Male", Age = 41, Id = 35 });
            Users.Add(new User { FirstName = "Miles", LastName = "Harold", Gender = "Male", Age = 31, Id = 45 });
            Users.Add(new User { FirstName = "Liam", LastName = "Conner", Gender = "Male", Age = 24, Id = 24 });
            Users.Add(new User { FirstName = "Nathaniel", LastName = "Peter", Gender = "Male", Age = 50, Id = 47 });
            Users.Add(new User { FirstName = "Ethan", LastName = "Hunter", Gender = "Male", Age = 22, Id = 5 });


            int UrId = 1;
            Users.ForEach(u =>
            {

                UserRoles.Add(new Entities.UserRoles  // All Users are employees
                {
                    Id = UrId,
                    RoleId = 3,
                    UserId = u.Id
                });
                if (UrId % 3 == 0) // Add Manager Role
                {
                    UrId++;
                    UserRoles.Add(new Entities.UserRoles  // All Users are employees
                    {
                        Id = UrId,
                        RoleId = 1,
                        UserId = u.Id
                    });
                }
                else if (UrId % 4 == 0) // Add Admin Role
                {
                    UrId++;
                    UserRoles.Add(new Entities.UserRoles
                    {
                        Id = UrId,
                        RoleId = 2,
                        UserId = u.Id
                    });
                }

                UrId++;

            }
            );


        }

    }
}
