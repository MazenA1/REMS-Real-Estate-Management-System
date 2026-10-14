using Models;
using Models.DTOs;
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

        /// <summary>
        /// Gets the basic information of a user by user ID for displaying
        /// created-by user information in the UI.
        /// </summary>
        /// <param name="userID">
        /// The ID of the user to retrieve.
        /// </param>
        /// <returns>
        /// A <see cref="CreatedByUserInfoDTO"/> if the user exists;
        /// otherwise, null.
        /// </returns>
        CreatedByUserInfoDTO GetCreatedByUserInfoByID(int userID); // This Meathod For User Control


        List <User> GetAll();

        bool Exists(int userID);
        bool ExistsByUserName(string userName);
        bool ExistsByPersonID(int personID);
    }
}