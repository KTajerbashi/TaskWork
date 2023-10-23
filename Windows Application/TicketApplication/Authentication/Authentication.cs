using BusinessLogic.Library;
using BusinessLogic.Library.Extentions;
using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.Repository.UserService;

namespace TicketApplication.Authentication
{
    public class Authentication
    {
        public Authentication(DatabaseContext context)
        {
        }
        public bool IsLogin(string username, string password)
        {
            UserService _service= new UserService();
            //You code here
            Result<User> user = _service.GetByUserName(username);
            bool isPasswordMatched = CryptoPassword.VerifyPassword(password, user.Data.Hash, user.Data.Salt);
            return isPasswordMatched ? true : false;
        }
    }
}
