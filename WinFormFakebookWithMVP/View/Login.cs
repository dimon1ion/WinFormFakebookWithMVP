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
    public partial class AccountPosts : Form, IUserView
    {
        int groupboxDefaultLocY;
        int EditID;
        public string Password { get; set; }
        public string NameUser { get; set; }
        public string Surname { get; set; }
        public List<string> Posts { get; set; }
        public List<Label> Labels { get; set; }
        public List<Button> ButtonsEdit { get; set; }
        public List<Button> ButtonsRemove { get; set; }
        public PresenterUser UserPresenter { get; set; }
        string IUserView.Login { get; set; }
        public AccountPosts(Start startForm)
        {
            InitializeComponent();
            NameUser = startForm.NameUser;
            Surname = startForm.Surname;
            Posts = startForm.Posts;
            UserPresenter = startForm.UserPresenter;
            this.Text = "Hi " + NameUser + ' ' + Surname + '!';
            groupboxDefaultLocY = groupBox1.Top;
            LoadFromPosts();
        }
        private void LoadFromPosts()
        {
            Labels = new List<Label>();
            ButtonsEdit = new List<Button>();
            ButtonsRemove = new List<Button>();
            Label label;
            Button buttonEdit;
            Button buttonRemove;
            int locYLabel;
            foreach (string comment in Posts)
            {
                locYLabel = 0;
                label = new Label();
                buttonEdit = new Button();
                buttonRemove = new Button();

                label.Text = comment;
                label.AutoSize = true;

                buttonEdit.Text = "Edit";
                buttonEdit.Height = 20;
                buttonEdit.Width = 50;

                buttonRemove.Text = "X";
                buttonRemove.Height = 20;
                buttonRemove.Width = 25;

                if (Labels.Count > 0)
                {
                    locYLabel = Labels[Labels.Count - 1].Top + Labels[Labels.Count - 1].Height + 5;
                }
                label.Top = locYLabel;
                label.Left = 10;
                this.Controls.Add(label);

                buttonEdit.Top = locYLabel;
                buttonEdit.Left = label.Left + label.Width;
                buttonEdit.Click += EditButton_Click;
                this.Controls.Add(buttonEdit);

                buttonRemove.Top = locYLabel;
                buttonRemove.Left = buttonEdit.Left + buttonEdit.Width;
                buttonRemove.Click += ButtonRemove_Click;
                this.Controls.Add(buttonRemove);

                Labels.Add(label);
                ButtonsEdit.Add(buttonEdit);
                ButtonsRemove.Add(buttonRemove);
            }
            if (Labels.Count > 0 && HScroll)
            {
                groupBox1.Top = Labels[Labels.Count - 1].Top + Labels[Labels.Count - 1].Height;
            }
        }
        private void LocRefresh()
        {
            textBox1.Text = String.Empty;
            if (Labels.Count == ButtonsEdit.Count && ButtonsEdit.Count == ButtonsRemove.Count)
            {
                if (Labels.Count > 1)
                {
                    ButtonsEdit[0].Left = Labels[0].Left + Labels[0].Width;
                    ButtonsRemove[0].Left = ButtonsEdit[0].Left + ButtonsEdit[0].Width;
                    for (int i = 0; i <= Labels.Count - 2; i++)
                    {
                        Labels[i + 1].Top = Labels[i].Top + Labels[i].Height + 10;
                        ButtonsEdit[i + 1].Top = Labels[i + 1].Top;
                        ButtonsEdit[i + 1].Left = Labels[i + 1].Left + Labels[i + 1].Width;
                        ButtonsRemove[i + 1].Top = Labels[i + 1].Top;
                        ButtonsRemove[i + 1].Left = ButtonsEdit[i + 1].Left + ButtonsEdit[i + 1].Width;
                    }
                    if (this.HScroll)
                    {
                        groupBox1.Top = Labels[Labels.Count - 1].Top + Labels[Labels.Count - 1].Height;
                        if (!this.HScroll)
                        {
                            groupBox1.Top = groupboxDefaultLocY;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, restart form..");
                Posts.Clear();
                UserPresenter.SaveUsers();
                this.Controls.Clear();
                InitializeComponent();
                LoadFromPosts();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Edit")
            {
                ButtonsEdit[EditID].Text = "Edit";
                Labels[EditID].Text = $"{NameUser} {Surname}\n{textBox1.Text}";
                Posts[EditID] = Labels[EditID].Text;
                LocRefresh();
                (sender as Button).Text = "Save";
                UserPresenter.SaveUsers();
                return;
            }
            Label label = new Label();
            Button buttonEdit = new Button();
            Button buttonRemove = new Button();

            label.AutoSize = true;
            label.Text = $"{NameUser} {Surname}\n";

            buttonEdit.Text = "Edit";
            buttonEdit.Height = 20;
            buttonEdit.Width = 50;

            buttonRemove.Text = "X";
            buttonRemove.Height = 20;
            buttonRemove.Width = 25;

            int i = 0, n = 0;
            foreach (var letter in textBox1.Text)
            {
                if (i == 100)
                {
                    label.Text += '\n';
                    n++;
                    i = 0;
                }
                if (letter == '\n')
                {
                    n++;
                }
                label.Text += letter;
                i++;
            }
            int locYLabel = 0;
            if (Labels.Count > 0)
            {
                locYLabel = Labels[Labels.Count - 1].Top + Labels[Labels.Count - 1].Height + 5;
            }

            label.Top = locYLabel;
            label.Left = 10;
            this.Controls.Add(label);

            buttonEdit.Top = locYLabel;
            buttonEdit.Left = label.Left + label.Width;
            buttonEdit.Click += EditButton_Click;
            this.Controls.Add(buttonEdit);

            buttonRemove.Top = locYLabel;
            buttonRemove.Left = buttonEdit.Left + buttonEdit.Width;
            buttonRemove.Click += ButtonRemove_Click;
            this.Controls.Add(buttonRemove);

            if (label.Top + label.Height > groupBox1.Top)
            {
                groupBox1.Top = label.Top + label.Height;
            }

            Labels.Add(label);
            ButtonsEdit.Add(buttonEdit);
            ButtonsRemove.Add(buttonRemove);
            Posts.Add(label.Text);
            UserPresenter.SaveUsers();
            textBox1.Text = String.Empty;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                int i = 0;
                for (; i < ButtonsRemove.Count; i++)
                {
                    if (sender == ButtonsRemove[i])
                    {
                        if (i == 0 && Labels.Count > 1)
                        {
                            Labels[1].Top = Labels[0].Top;
                            ButtonsEdit[1].Top = Labels[0].Top;
                            ButtonsRemove[1].Top = Labels[0].Top;
                        }
                        addButton.Text = "Save";
                        this.Controls.Remove(Labels[i]);
                        this.Controls.Remove(ButtonsEdit[i]);
                        this.Controls.Remove(ButtonsRemove[i]);
                        Posts.RemoveAt(i);
                        Labels.RemoveAt(i);
                        ButtonsEdit.RemoveAt(i);
                        ButtonsRemove.RemoveAt(i);
                        LocRefresh();
                        UserPresenter.SaveUsers();
                        break;
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if ((sender as Button).Text == "Edit")
                {
                    int i = 0;
                    for (; i < ButtonsEdit.Count; i++)
                    {
                        if (sender == ButtonsEdit[i])
                        {
                            addButton.Text = "Edit";
                            EditID = i;
                            string[] tmp = Labels[i].Text.Split('\n');
                            textBox1.Text = String.Empty;
                            for (int j = 1; j < tmp.Length; j++)
                            {
                                if (j > 1) { textBox1.Text += '\n'; }
                                textBox1.Text += tmp[j];
                            }
                            (sender as Button).Text = "Cancle";
                            break;
                        }
                    }
                }
                else
                {
                    addButton.Text = "Save";
                    (sender as Button).Text = "Edit";
                }
            }
        }

    }
}
