
namespace FirstProject_WinForm
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorLoginLabel = new System.Windows.Forms.Label();
            this.errorPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "W e l c o m e";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(123, 117);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(126, 16);
            this.loginTextBox.TabIndex = 1;
            // 
            // passTextBox
            // 
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(123, 179);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(126, 16);
            this.passTextBox.TabIndex = 2;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Old English Text MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(231, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorLoginLabel
            // 
            this.errorLoginLabel.AutoSize = true;
            this.errorLoginLabel.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLoginLabel.Location = new System.Drawing.Point(171, 97);
            this.errorLoginLabel.Name = "errorLoginLabel";
            this.errorLoginLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLoginLabel.TabIndex = 7;
            // 
            // errorPasswordLabel
            // 
            this.errorPasswordLabel.AutoSize = true;
            this.errorPasswordLabel.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPasswordLabel.Location = new System.Drawing.Point(198, 159);
            this.errorPasswordLabel.Name = "errorPasswordLabel";
            this.errorPasswordLabel.Size = new System.Drawing.Size(0, 20);
            this.errorPasswordLabel.TabIndex = 8;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(383, 308);
            this.Controls.Add(this.errorPasswordLabel);
            this.Controls.Add(this.errorLoginLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Start";
            this.Text = "Fakebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorLoginLabel;
        private System.Windows.Forms.Label errorPasswordLabel;
    }
}

