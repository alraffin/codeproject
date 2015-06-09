using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Sample_MVCApp.Models
{
    public class UserModels
    {
       
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        public string Address { get; set; }
       
       
        public string Email { get; set; }
       
        public DateTime DOB { get; set; }
       
        public decimal Salary { get; set; }
    }
    public class Users
    {
        public Users()
        {
            _userList.Add(new UserModels
            {
                FirstName = "Anuja",
                LastName = "Pawar",
                Address = "Indore MP",
                Email = "test@test.com",
                DOB = Convert.ToDateTime("6/22/1976"),
                Salary = 40000

            });
            _userList.Add(new UserModels
            {
                FirstName = "Deerghika",
                LastName = "Pawar",
                Address = "Indore MP",
                Email = "test1@test.com",
                DOB = Convert.ToDateTime("7/11/2001"),
                Salary = 7000

            });
            _userList.Add(new UserModels
            {
                FirstName = "Arnav",
                LastName = "Pawar",
                Address = "Indore MP",
                Email = "test2@test.com",
                DOB = Convert.ToDateTime("3/12/2010"),
                Salary = 5000

            });
        }

        public List<UserModels> _userList = new List<UserModels>();

        public void CreateUser(UserModels userModel)
        {
            _userList.Add(userModel);
        }

        public void UpdateUser(UserModels userModel)
        {
            foreach (UserModels usrlst in _userList)
            {
                if (usrlst.Email == userModel.Email)
                {
                    _userList.Remove(usrlst);
                    _userList.Add(userModel);
                    break;
                }
            }
        }
        public  UserModels GetUser(string Email) {
            UserModels usrMdl = null;

            foreach (UserModels um in _userList)
                if (um.Email == Email)
                    usrMdl = um;

            return usrMdl;
        }

       
    }
}
