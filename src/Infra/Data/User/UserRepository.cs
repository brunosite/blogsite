using Domain.User;
using Domain.User.Interface;

namespace Data.User
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        
    }
}