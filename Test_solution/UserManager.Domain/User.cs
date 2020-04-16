using System;

namespace UserManager.Domain
{
    public class User
    {
        private string lastName = string.Empty;
        private string name = string.Empty;
        private string login = string.Empty;
        private string password = string.Empty;
        private int active = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Active
        {
            get { return active; }
            set { active = value; }
        }

    }
}
