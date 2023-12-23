using blinkCore.Contracts.Entities;
using blinkCore.Contracts.Repository;
using blinkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blinkServices
{
    internal class UserService : BaseService<User>, IUserService
    {
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
        }

    }
}
