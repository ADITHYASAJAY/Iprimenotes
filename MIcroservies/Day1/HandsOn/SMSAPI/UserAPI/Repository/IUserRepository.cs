using UserAPI.Model;

namespace UserAPI.Repository
{
    public interface IUserRepository
    {
        void Register(User user);
        User Validate(string userName, string password);
        void EditUser(User user);

    }
}
