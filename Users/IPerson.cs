using System;
using System.Collections.Generic;
using System.Text;

namespace ScholarStation.Users
{
    public interface IPerson
    {
        string Name
        {
            get;
            set;
        }

        int ID
        {
            get;
            set;
        }

        string Password
        {
            get;
            set;
        }

        int PermissionLevel
        {
            get;
        }
    }
}
