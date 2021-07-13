using FirstProject_WinForm.Model;
using FirstProject_WinForm.Presenter;
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
    public partial class Sign_up : Form, IUserView
    {
        Start start;
        public Sign_up(Start start)
        {
            InitializeComponent();
            UserPresenter = start.UserPresenter;
            this.start = start;
        }

        public string Login { get => loginTextBox.Text; set => loginTextBox.Text = value; }
        public string Password { get => passTextBox.Text; set => passTextBox.Text = value; }
        public string NameUser { get => nameTextBox.Text; set => nameTextBox.Text = value; }
        public string Surname { get => surnameTextBox.Text; set => surnameTextBox.Text = value; }
        public List<string> Posts { get; set; }
        public PresenterUser UserPresenter { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorLoginLabel.Text = String.Empty;
            errorNameLabel.Text = String.Empty;
            errorSurnameLabel.Text = String.Empty;
            errorPassLabel.Text = String.Empty;
            bool loginError = false, loginUsed = false, nameError = false, surnameError = false, passError = false;
            if (loginTextBox.Text != String.Empty)
            {
                if (start.UserPresenter.CheckUser(loginTextBox.Text, null))
                {
                    errorLoginLabel.Text = "*This login is used";
                    loginUsed = true;
                }
            }
            else { errorLoginLabel.Text = "*"; loginError = true; }
            if (nameTextBox.Text == String.Empty)
            {
                errorNameLabel.Text = "*";
                nameError = true;
            }
            if (surnameTextBox.Text == String.Empty)
            {
                errorSurnameLabel.Text = "*";
                surnameError = true;
            }
            if (passTextBox.Text.Length < 8)
            {
                errorPassLabel.Text = "*Use 8 characters or more for your password";
                passError = true;
            }

            if (!loginError && !loginUsed && !nameError && !surnameError && !passError)
            {
                start.UserPresenter.NewUser(new User(loginTextBox.Text, passTextBox.Text, nameTextBox.Text, surnameTextBox.Text));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
