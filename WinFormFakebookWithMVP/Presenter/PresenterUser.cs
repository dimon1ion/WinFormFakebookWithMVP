using FirstProject_WinForm.Model;
using FirstProject_WinForm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject_WinForm.Presenter
{
    public class PresenterUser
    {
        RepositoryUser repository;
        IUserView view;
        public bool rightLogin { get; set; }
        public PresenterUser(IUserView view, RepositoryUser repository)
        {
            this.repository = repository;
            view.UserPresenter = this;
            this.view = view;
            rightLogin = false;
            DefaultProp();
        }
        private void DefaultProp()
        {
            if (repository.GetAllUsers().Count() > 0)
            {
                User tmpU = repository.GetUserByID(0);
                view.NameUser = tmpU.NameUser;
                view.Surname = tmpU.Surname;
                view.Posts = tmpU.Posts;
            }
        }
        public bool CheckUser(string login, string pass)
        {
            rightLogin = false;
            if (repository.GetAllUsers().Where(x => x.Login == login).Count() > 0)
            {
                try
                {
                    if (pass != null)
                    {
                        User tmpU = repository.GetAllUsers().Where(x => x.Login == login && x.Password == pass).ToList().ElementAt(0);
                        view.NameUser = tmpU.NameUser;
                        view.Surname = tmpU.Surname;
                        view.Posts = tmpU.Posts;
                        return true;
                    }
                    else { return true; }
                }
                catch (Exception) { }
                rightLogin = true;
            }
            return false;
        }
        public void NewUser(User newUser)
        {
            repository.AddUser(newUser);
        }
        public void SaveUsers()
        {
            repository.SaveUsers(null);
        }
    }
}
