using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarStation
{
    class UserFactory : IUserFactory
    {
        public User CreateUser(UserType type)
        {
            User user = null;
            if (type == UserType.Standard)
            {
                user = new User("",1,UserType.Standard);
            }
            else if(type == UserType.Professor)
            {
                user = new User("", 2, UserType.Professor);
            }
            return user;
        }
    }
}
