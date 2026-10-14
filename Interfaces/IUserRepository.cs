using Models;
using Models.DTOs;
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

        /// <summary>
        /// Retrieves the basic information of the user who created a record,
        /// using the specified user ID.
        /// </summary>
        /// <param name="userID">
        /// The ID of the user whose information will be retrieved.
        /// </param>
        /// <returns>
        /// A <see cref="CreatedByUserInfoDTO"/> containing the user's basic information,
        /// or null if no matching user is found.
        /// </returns>
        CreatedByUserInfoDTO GetCreatedByUserInfoByID(int userID); // This Meathod For User Control


        List<User> GetAll();
        bool Exists(int userID);
        bool ExistsByUserName(string userName);
        bool ExistsByPersonID(int personID);
        User FindUserByUserNameAndPassword(string userName, string password); 
    }
}