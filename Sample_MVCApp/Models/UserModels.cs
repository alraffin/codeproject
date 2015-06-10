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
        [DisplayName("First Name")]
        [Required (ErrorMessage="First name is required")]
        public string FirstName { get; set; }
       
        [DisplayName("Last Name")]
        [Required (ErrorMessage="Last name is required")]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
       
       
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
       
        [Range(1200, 10000)]
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
                Salary = 4000

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
                    usrMdl = um; // why not return um; right there?
 
            return usrMdl;
        }

       
    }
}
