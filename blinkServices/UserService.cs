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
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> VerifyUser(string email)
        {
            var user = _userRepository.FindByEmail(email);

            if (user != null)
            {
                return Task.FromResult(user);
            }
            return null;
        }
    }
}
