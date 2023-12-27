using blinkCore.Contracts.Repository;
using blinkCore.Entities;

namespace blinkRepository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context) : base(context)
        {
            _context = context;
        }

        public User FindByEmail(string email)
        {
            return _context.Set<User>().FirstOrDefault(x => x.Email == email);
        }
    }
}
