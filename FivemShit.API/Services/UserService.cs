using FivemShit.API.ContextClasses;
using FivemShit.API.HelpingTables.TokenManager;
using FivemShit.API.Repositories;

namespace FivemShit.API.Services
{
    public class UserService : IUserInterface
    {
        private readonly DataContext dbcon;
        private readonly ITokenService tokenmanager;
        public UserService(DataContext dbcon, ITokenService tokenmanager)
        {
            this.dbcon = dbcon;
            this.tokenmanager = tokenmanager;
        }
    }
}
