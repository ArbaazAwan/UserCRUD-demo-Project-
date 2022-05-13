using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUser
    {
        //get all users
        List<User> GetAllUsers();
        //get one user
        User GetUserByID(int Id);
        //add user
        string AddUser(User user);
        //update user
        string UpdateUser(User user);
        //delete user
        string RemoveUser(int Id);
    }
}
