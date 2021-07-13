using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject_WinForm.Model
{
    public class User
    {
        public User()
        {
        }
        public User(string login, string password, string name, string surname)
        {
            Login = login;
            Password = password;
            NameUser = name;
            Surname = surname;
            Posts = new List<string>();
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string NameUser { get; set; }
        public string Surname { get; set; }
        public List<string> Posts { get; set; }
    }
}
