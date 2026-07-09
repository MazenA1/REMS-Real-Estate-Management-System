using Interfaces;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private bool _AddUser(User user)
        {
            int userID = _userRepository.Add(user);

            if (userID != -1)
            {
                user.UserID = userID;
                return true;
            }

            return false;
        }

        private bool _UpdateUser(User user)
        {
            return _userRepository.Update(user);
        }

        public bool Save(User user)
        {
            switch (user.Mode)
            {
                case User.enMode.AddNew:
                    if (_AddUser(user))
                    {
                        user.Mode = User.enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case User.enMode.Update:
                    return _UpdateUser(user);
            }

            return false;
        }

        public bool Delete(int userID)
        {
            return _userRepository.Delete(userID);
        }

        public User GetByID(int userID)
        {
            return _userRepository.GetByID(userID);
        }

        public User GetByUserName(string userName)
        {
            return _userRepository.GetByUserName(userName);
        }

        public User GetByPersonID(int personID)
        {
            return _userRepository.GetByPersonID(personID);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public bool Exists(int userID)
        {
            return _userRepository.Exists(userID);
        }

        public bool ExistsByUserName(string userName)
        {
            return _userRepository.ExistsByUserName(userName);
        }

        public bool ExistsByPersonID(int personID)
        {
            return _userRepository.ExistsByPersonID(personID);
        }
        public User FindUserByUserNameAndPassword(string userName, string Password)
        {
            return _userRepository.FindUserByUserNameAndPassword(userName, Password);
        }
    }
}