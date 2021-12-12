using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finalProgact
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public static TextBox userNameText ;
        public LoginForm()
        {
            InitializeComponent();
            instance = this;
            userNameText = textBoxUserName;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Pictures\\login.gif");
        }

        private void butLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void butLogin_Click_1(object sender, EventArgs e)
        {
            if(this.textBoxUserName.Text == "admin" && this.textBoxPassword.Text == "admin"){
                this.Hide();
                Form mainForm = new Form1();
                mainForm.ShowDialog();
                this.Close();
            }
            if (this.textBoxUserName.Text == "user" && this.textBoxPassword.Text == "user")
            {
                this.Hide();
                Form mainForm = new Form1();
                mainForm.ShowDialog();
                this.Close();
            }
            faildLogin.Visible = true;
        }
        
        
    }
}
