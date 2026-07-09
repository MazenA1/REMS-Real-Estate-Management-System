using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IUserRepository
    {
        int Add(User user);
        bool Update(User user);
        bool Delete(int userID);

        User GetByID(int userID);
        User GetByUserName(string userName);
        User GetByPersonID(int personID);

        List<User> GetAll();

        bool Exists(int userID);
        bool ExistsByUserName(string userName);
        bool ExistsByPersonID(int personID);
        User FindUserByUserNameAndPassword(string userName, string password); 
    }
}