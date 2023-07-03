using BusinessModels;
using DataModels;

namespace DataLayer
{
    /// <summary>
    /// this class stores data of the users in a list of lists amd performs signup and login operations
    /// </summary>
    public class DALAuthentication : IDALAuthentication
    {
        /// <summary>
        /// this method adds data of the user into the list while signing up
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public void AddData(BusinessModels.User userObj)
        {           
            DataSource.data.Add(new DataModels.User { Username = userObj.Username, Password = userObj.Password, Email = userObj.Email });
        }

        /// <summary>
        /// This method checks whether data entered by user while logging in is correct or not by checking in the list
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateLogin(BusinessModels.User userObj)
        {
            DataModels.User user = DataSource.data.Find(user => user.Username == userObj.Username);
            if (user != null && user.Password == userObj.Password)
            {
                return true;
            }
            return false;           
        }
        /// <summary>
        /// This method will validate whether the given details are valid or not
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public bool ValidateUser(BusinessModels.User userObj)
        {
            DataModels.User user = DataSource.data.Find(user => user.Username == userObj.Username);
            if (user != null && user.Email == userObj.Email)
            {
                return true;
            }
            return false;           
        }
        /// <summary>
        /// This method will update the new password in the users data
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public void UpdatePassword(BusinessModels.User userObj)
        {
            DataModels.User user = DataSource.data.Find(user => user.Username == userObj.Username);
            if (user != null )
            {
                user.Password = userObj.Password;
            }                      
        }

        /// <summary>
        /// this method validates whether the username entered is valid or not
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        public bool ValidateUsername(string Username)
        {
            DataModels.User user = DataSource.data.Find(user => user.Username == Username);
            if (user != null )
            {
                return false;
            }
            return true;           
        }
    }
}