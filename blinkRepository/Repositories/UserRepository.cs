using blinkCore.Contracts.Repository;
using blinkCore.Entities;

namespace blinkRepository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }
    }
}
