using FirstProject_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject_WinForm
{
    public interface IUserView
    {
        string Login { get; set; }
        string Password { get; set; }
        string NameUser { get; set; }
        string Surname { get; set; }
        List<string> Posts { get; set; }
        PresenterUser UserPresenter { get; set; }
    }
}
