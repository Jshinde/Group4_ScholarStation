using System;
using System.Collections.Generic;
using System.Text;

namespace ScholarStation.Users
{
    class DeptRepresentative : IPerson
    {
        private String name;
        private String password;
        private int id;
        private readonly int permissionsLvl = 2;

        public DeptRepresentative()
        {
            this.name = "";
            this.password = "";
            this.id = 0;
        }

        public DeptRepresentative(String newName, String newPassword, int newID, int newPermissions)
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
