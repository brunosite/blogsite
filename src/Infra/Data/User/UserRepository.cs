using System.Collections.Generic;
using Domain.User.Interface;

namespace Data.User
{
    public class UserRepository : IUserRepository
    {
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