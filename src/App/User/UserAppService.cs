using System.Collections.Generic;
using App.User.Interface;
using Domain.User;
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
        
        public ICollection<UserEntity> All()
        {
            throw new System.NotImplementedException();
        }

        public IList<UserEntity> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<UserEntity> FindWhere()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserEntity> Update()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserEntity> Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}