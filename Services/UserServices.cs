using Domain.Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserServices : IUser
    {
        private AppDbContext _dbContext;
        public UserServices(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Add User
        public string AddUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return "Success";
            }
            catch (Exception)
            {
                return "Failure";
            }
        }
        //Get All Users
        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList(); 
        }
        //Get one user
        public User GetUserByID(int Id)
        {
            return _dbContext.Users.Where(a => a.userId == Id).FirstOrDefault();
        }

        public string RemoveUser(int Id)
        {
            try
            {
                var user = _dbContext.Users.Find(Id);
                _dbContext.Remove(user);
                return "success";
            }
            catch (Exception)
            {
                return "Failure";
            }
        }
        //update the user
        public string UpdateUser(User user)
        {
            try
            {
                var userValue = _dbContext.Users.Find(user.userId);
                if (userValue != null)
                {
                    userValue.userName = user.userName;
                    userValue.userEmail = user.userEmail;
                    userValue.userPhone = user.userPhone;
                    userValue.userAddress = user.userAddress;
                    _dbContext.SaveChanges();
                    return "Success";
                }
                else
                    return "User Doesn't Exists";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
