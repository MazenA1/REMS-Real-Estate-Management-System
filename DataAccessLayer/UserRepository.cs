using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DataAccessLayer
{
    public class UserRepository : IUserRepository
    {
        public int Add(User user)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewUser",
                    new SqlParameter("@PersonID", user.PersonID),
                    new SqlParameter("@UserName", user.UserName),
                    new SqlParameter("@Password", user.Password),
                    new SqlParameter("@IsActive", user.IsActive),
                    new SqlParameter("@Permissions", user.Permissions)
                );

                return (result != null && int.TryParse(result.ToString(), out int userID))
                    ? userID
                    : -1;
            }
            catch
            {
                return -1;
            }
        }

        public bool Update(User user)
        {
            try
            {
                int rowsAffected = SqlHelper.ExecuteNonQuery(
                    "SP_UpdateUser",
                    new SqlParameter("@UserID", user.UserID),
                    new SqlParameter("@PersonID", user.PersonID),
                    new SqlParameter("@UserName", user.UserName),
                    new SqlParameter("@Password", user.Password),
                    new SqlParameter("@IsActive", user.IsActive),
                    new SqlParameter("@Permissions", user.Permissions)
                );

                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }

        public User FindUserByUserNameAndPassword(string userName, string password)
        {
            User user = null;

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_FindUserByUserNameAndPassword",
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@Password", password)))
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserID = (int)reader["UserID"],
                            PersonID = (int)reader["PersonID"],
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            IsActive = (bool)reader["IsActive"],
                            Permissions = (int)reader["Permissions"]
                        };
                    }

                }
                    return user;
            }

            catch(Exception ex)
            {
                return null;
            }
        }
        public bool Delete(int userID)
        {
            try
            {
                int rowsAffected = SqlHelper.ExecuteNonQuery(
                    "SP_DeleteUser",
                    new SqlParameter("@UserID", userID)
                );

                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }

        public User GetByID(int userID)
        {
            User user = null;

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetUserByID",
                    new SqlParameter("@UserID", userID)))
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserID = (int)reader["UserID"],
                            PersonID = (int)reader["PersonID"],
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            IsActive = (bool)reader["IsActive"],
                            Permissions = (int)reader["Permissions"]
                        };
                    }
                }

                return user;
            }
            catch
            {
                return null;
            }
        }

        public User GetByUserName(string userName)
        {
            User user = null;

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetUserByUserName",
                    new SqlParameter("@UserName", userName)))
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserID = (int)reader["UserID"],
                            PersonID = (int)reader["PersonID"],
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            IsActive = (bool)reader["IsActive"],
                            Permissions = (int)reader["Permissions"]
                        };
                    }
                }

                return user;
            }
            catch
            {
                return null;
            }
        }

        public User GetByPersonID(int personID)
        {
            User user = null;

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetUserByPersonID",
                    new SqlParameter("@PersonID", personID)))
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserID = (int)reader["UserID"],
                            PersonID = (int)reader["PersonID"],
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            IsActive = (bool)reader["IsActive"],
                            Permissions = (int)reader["Permissions"]
                        };
                    }
                }

                return user;
            }
            catch
            {
                return null;
            }
        }

        public List<User> GetAll()
        {
            List<User> list = new List<User>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllUsers"))
                {
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            UserID = (int)reader["UserID"],
                            PersonID = (int)reader["PersonID"],
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            IsActive = (bool)reader["IsActive"],
                            Permissions = (int)reader["Permissions"]
                        };

                        list.Add(user);
                    }
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        public bool Exists(int userID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsUserExist",
                    new SqlParameter("@UserID", userID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch
            {
                return false;
            }
        }

        public bool ExistsByUserName(string userName)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsUserExistByUserName",
                    new SqlParameter("@UserName", userName)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch
            {
                return false;
            }
        }

        public bool ExistsByPersonID(int personID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsUserExistByPersonID",
                    new SqlParameter("@PersonID", personID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}