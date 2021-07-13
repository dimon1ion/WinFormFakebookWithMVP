using FirstProject_WinForm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FirstProject_WinForm.Repository
{
    public class RepositoryUser
    {
        List<User> users { get; set; }
        string xmlpath;
        XmlSerializer xmlSerializer;
        public RepositoryUser(string _path)
        {
            users = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
            xmlpath = _path + "\\Fakebook.xml";
            if (!File.Exists(xmlpath))
            {
                DefaultUser();
            }
            using (FileStream fs = new FileStream(xmlpath, FileMode.Open))
            {
                users = (List<User>)xmlSerializer.Deserialize(fs);
            }
        }
        private void DefaultUser()
        {
            List<User> defaultuser = new List<User>() { new User("dimonlion", "0000", "Dimon", "Lion") };
            SaveUsers(defaultuser);
        }
        public void SaveUsers(List<User> users)
        {
            if (users == null)
            {
                users = this.users;
            }
            using (TextWriter ser = new StreamWriter(xmlpath))
            {
                xmlSerializer.Serialize(ser, users);
            }
        }
        public void AddUser(User user)
        {
            users.Add(user);
            SaveUsers(users);
        }
        public User GetUserByID(int id)
        {
            if (users.Count > id && id >= 0)
                return users[id];
            return null;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }
    }
}
