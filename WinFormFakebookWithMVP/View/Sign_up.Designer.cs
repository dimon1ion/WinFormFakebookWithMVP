
namespace FirstProject_WinForm
{
    partial class Sign_up
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorLoginLabel = new System.Windows.Forms.Label();
            this.errorNameLabel = new System.Windows.Forms.Label();
            this.errorSurnameLabel = new System.Windows.Forms.Label();
            this.errorPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.loginTextBox.Location = new System.Drawing.Point(62, 47);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(185, 16);
            this.loginTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.Location = new System.Drawing.Point(62, 97);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 16);
            this.nameTextBox.TabIndex = 1;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.surnameTextBox.Location = new System.Drawing.Point(62, 144);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(185, 16);
            this.surnameTextBox.TabIndex = 2;
            // 
            // passTextBox
            // 
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.passTextBox.Location = new System.Drawing.Point(62, 191);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(185, 16);
            this.passTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 12F);
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 12F);
            this.label2.Location = new System.Drawing.Point(62, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 12F);
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 12F);
            this.label4.Location = new System.Drawing.Point(62, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(9, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Old English Text MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(226, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorLoginLabel
            // 
            this.errorLoginLabel.AutoSize = true;
            this.errorLoginLabel.Font = new System.Drawing.Font("Old English Text MT", 12F);
            this.errorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLoginLabel.Location = new System.Drawing.Point(122, 24);
            this.errorLoginLabel.Name = "errorLoginLabel";
            this.errorLoginLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLoginLabel.TabIndex = 10;
            // 
            // errorNameLabel
            // 
            this.errorNameLabel.AutoSize = true;
            this.errorNameLabel.Font = new System.Drawing.Font("Old English Text MT", 12F);
            this.errorNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorNameLabel.Location = new System.Drawing.Point(122, 76);
            this.errorNameLabel.Name = "errorNameLabel";
            this.errorNameLabel.Size = new System.Drawing.Size(0, 20);
            this.errorNameLabel.TabIndex = 11;
            // 
            // errorSurnameLabel
            // 
            this.errorSurnameLabel.AutoSize = true;
            this.errorSurnameLabel.Font = new System.Drawing.Font("Old English Text MT", 12F);
            this.errorSurnameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorSurnameLabel.Location = new System.Drawing.Point(140, 123);
            this.errorSurnameLabel.Name = "errorSurnameLabel";
            this.errorSurnameLabel.Size = new System.Drawing.Size(0, 20);
            this.errorSurnameLabel.TabIndex = 12;
            // 
            // errorPassLabel
            // 
            this.errorPassLabel.AutoSize = true;
            this.errorPassLabel.Font = new System.Drawing.Font("Old English Text MT", 8.45F);
            this.errorPassLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPassLabel.Location = new System.Drawing.Point(148, 174);
            this.errorPassLabel.Name = "errorPassLabel";
            this.errorPassLabel.Size = new System.Drawing.Size(0, 16);
            this.errorPassLabel.TabIndex = 13;
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(358, 290);
            this.Controls.Add(this.errorPassLabel);
            this.Controls.Add(this.errorSurnameLabel);
            this.Controls.Add(this.errorNameLabel);
            this.Controls.Add(this.errorLoginLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "Sign_up";
            this.Text = "Sign_up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorLoginLabel;
        private System.Windows.Forms.Label errorNameLabel;
        private System.Windows.Forms.Label errorSurnameLabel;
        private System.Windows.Forms.Label errorPassLabel;
    }
}