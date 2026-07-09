using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IUserService
    {
        bool Save(User user);
        bool Delete(int userID);

        User GetByID(int userID);
        User GetByUserName(string userName);
        User GetByPersonID(int personID);
        User FindUserByUserNameAndPassword(string userName, string Password);

        List <User> GetAll();

        bool Exists(int userID);
        bool ExistsByUserName(string userName);
        bool ExistsByPersonID(int personID);
    }
}