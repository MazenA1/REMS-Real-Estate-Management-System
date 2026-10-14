using Helpers;
using Interfaces;
using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DataAccessLayer
{
    public class UserRepository : IUserRepository
    {
        private readonly IAppLogger _logger;

        public UserRepository(IAppLogger logger) 
        {
            _logger = logger;
        }
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

        /// <inheritdoc/>
        public CreatedByUserInfoDTO GetCreatedByUserInfoByID(int userID)
        {
            CreatedByUserInfoDTO userInfo = null;

            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@UserID",
                        userID)
                };

                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader(
                        "SP_GetCreatedByUserInfoByID",
                        parameters))
                {
                    if (reader.Read())
                    {
                        userInfo =
                            _MapCreatedByUserInfo(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                this._logger.LogError(
                    "Error getting created-by user info by ID.",
                    ex);

                throw;
            }

            return userInfo;
        }
        private CreatedByUserInfoDTO _MapCreatedByUserInfo(SqlDataReader reader)
        {
            return new CreatedByUserInfoDTO
            {
                UserID =
                    Convert.ToInt32(
                        reader["UserID"]),

                UserName =
                    reader["UserName"] == DBNull.Value
                        ? null
                        : reader["UserName"].ToString(),

                IsActive =
                    Convert.ToBoolean(
                        reader["IsActive"])
            };
        }
    }
}