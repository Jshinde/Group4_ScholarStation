using System;
using System.Collections.Generic;
using System.Text;

namespace ScholarStation.Users
{
    class StandardUser : IPerson
    {
        private String name;
        private int id;
        private String password;
        private readonly int permissionsLvl = 4;

        public StandardUser()
        {
            this.name = "";
            this.id = 0;
            this.password = "";
        }

        public StandardUser(String newName, String newPassword, int newID)
        {
            this.name = newName;
            this.password = newPassword;
            this.id = newID;
        }

        public String Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public String Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        public int PermissionLevel
        {
            get
            {
                return this.permissionsLvl;
            }
        }

        public override String ToString()
        {
            return "Name: " + this.name + "\nID Number: " + this.id + "\nPermission Level: " + this.permissionsLvl;
        }
    }
}
