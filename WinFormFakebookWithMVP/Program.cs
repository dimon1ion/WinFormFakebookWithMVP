using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject_WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Start view = new Start();

            Repository.RepositoryUser repositoryUser = new Repository.RepositoryUser(Application.StartupPath);
            
            Presenter.PresenterUser presenterUser = new Presenter.PresenterUser(view, repositoryUser);

            //var test = new AccountPosts(view);

            Application.Run(view);
        }
    }
}
