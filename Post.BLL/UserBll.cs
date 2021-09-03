using Post.IDAL;
using Post.Model;
using System;
using System.Collections.Generic;

namespace Post.BLL
{
    public class UserBll        
    {

        private readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetUser(int userNumber)
        {
            if(userNumber <= 0)
            {
                throw new ArgumentException();
            }
            return _userDal.GetUser(userNumber);
        }

        public List<User> GetUserList()
        {
            throw new NotImplementedException();
        }

        public bool SaveUser(User user)
        {
            if(user == null)
            {
                throw new ArgumentNullException();
            }
            return _userDal.SaveUser(user);
        }
    }
}
