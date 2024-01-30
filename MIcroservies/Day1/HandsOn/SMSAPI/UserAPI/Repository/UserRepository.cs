using UserAPI.Model;

namespace UserAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        List<User> _users = new List<User>();  
        public void EditUser(User user)
        {
            foreach (var u in _users) 
            {
                if (u.UserId == user.UserId) 
                {
                    u.Email = user.Email;
                    u.Password = user.Password;
                }
            }
        }

        public void Register(User user)
        {
           _users.Add(user);
        }

        public User Validate(string userName, string password)
        {
            return _users.SingleOrDefault(u => u.UserName == userName && u.Password == password);
        }
    }
}
