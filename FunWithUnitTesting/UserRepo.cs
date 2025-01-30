using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static FunWithUnitTesting.UserService;

namespace FunWithUnitTesting
{
    public class UserRepoFake : IUserRepo
    {
        private readonly UserService.User _userToReturn;

        public UserRepoFake(UserService.User userToReturn = null)
        {
            _userToReturn = userToReturn;
        }

        public UserService.User GetUserFromDbByEmail(string email)
        {
            return _userToReturn;
        }

        public string AddUserToDb(UserService.User user)
        {
            return string.Empty; // Успешное добавление
        }
    }
}
