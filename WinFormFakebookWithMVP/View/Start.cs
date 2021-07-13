using FirstProject_WinForm.Model;
using FirstProject_WinForm.Presenter;
using FirstProject_WinForm.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject_WinForm
{
    public partial class Start : Form,IUserView
    {
        Sign_up sign_Up;
        AccountPosts login;

        public string Login { get => loginTextBox.Text; set => loginTextBox.Text = value; }
        public string Password { get => passTextBox.Text; set => passTextBox.Text = value; }
        public string NameUser { get; set; }
        public string Surname { get; set; }
        public List<string> Posts { get; set; }
        public PresenterUser UserPresenter { get; set; }

        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorPasswordLabel.Text = String.Empty;
            errorLoginLabel.Text = String.Empty;
            if (UserPresenter.CheckUser(Login, Password))
            {
                login = new AccountPosts(this);
                this.Visible = false;
                login.ShowDialog();
                this.Visible = true;
            }
            else if (UserPresenter.rightLogin)
            {
                errorPasswordLabel.Text = "*Password is incorrect";
            }
            else
            {
                errorLoginLabel.Text = "*Login not found";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_Up = new Sign_up(this);
            this.Visible = false;
            if (sign_Up.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }
            this.Visible = true;
        }
    }
}
