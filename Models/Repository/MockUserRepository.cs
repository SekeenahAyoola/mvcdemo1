using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models.Enums;

namespace BulkyBooksmvc.Models.Repository
{
    public class MockUserRepository
    {
        private static List<User> listOfUsers = new List<User>
        {
            new User{Id = 1, Email = "", PassWord ="", Gender = Gender.Male, UserName = "" },
            new User{Id = 1, Email = "", PassWord ="", Gender = Gender.Male, UserName = "" },
            new User{Id = 1, Email = "", PassWord ="", Gender = Gender.Male, UserName = "" },
            new User{Id = 1, Email = "", PassWord ="", Gender = Gender.Male, UserName = "" }
        };
        
    }
}