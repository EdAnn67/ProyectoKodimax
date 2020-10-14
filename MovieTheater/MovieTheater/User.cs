using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class User
    {
        public string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string birth;
        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string username;
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string password;
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }

        public int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

    }
}
