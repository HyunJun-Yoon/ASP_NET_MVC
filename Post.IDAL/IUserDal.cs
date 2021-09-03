using Post.Model;
using System.Collections.Generic;

namespace Post.IDAL
{
    public interface IUserDal
    {
        List<User> GetUserList();

        User GetUser(int userNumber);

        bool SaveUser(User user);
    }
}
