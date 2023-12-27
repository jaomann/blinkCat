using blinkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blinkCore.Contracts.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User FindByEmail(string email);
    }
}
