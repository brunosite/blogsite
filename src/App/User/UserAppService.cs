using System.Collections.Generic;
using App.User.Interface;
using Domain.User.Interface;

namespace App.User
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository _userRepository;
        
        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public ICollection<Domain.User.User> All()
        {
            throw new System.NotImplementedException();
        }

        public IList<Domain.User.User> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Domain.User.User> FindWhere()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Domain.User.User> Update()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Domain.User.User> Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}