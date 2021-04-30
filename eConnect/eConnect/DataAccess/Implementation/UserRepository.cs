using eConnect.DataAccess.Contract;
using System.Linq;

namespace eConnect.DataAccess.Implementation
{
    public class UserRepository : IUserRepository
    {
        private eConnectEntities entities = null;

        public UserRepository()
        {
            entities = new eConnectEntities();
        }
        public bool ValidateUser(string username, string password)
        {
            return entities.Users.Any(t => t.UserName == username && t.Password == password);
        }
    }
}