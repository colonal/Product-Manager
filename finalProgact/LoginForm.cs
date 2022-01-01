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
        public  List<String> data = new List<String> {};
        public LoginForm()
        {
            InitializeComponent();
            instance = this;
            userNameText = textBoxUserName;
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("..\\..\\icons\\login.gif");
            DataManagementSaveLogin isSave = new DataManagementSaveLogin();
            List<String> dataSave =  isSave.IsSave();
            if (dataSave.Count != 0)
            {
                checkBoxSave.Checked = true;
                textBoxUserName.Text = dataSave[0];
                textBoxPassword.Text = dataSave[1];
            }
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
            butLogin.Text = "Loading ...";
            
            
            if (this.textBoxUserName.Text == "" && this.textBoxPassword.Text == "") {
                faildLogin.Visible = true;
                faildLogin.Text = "Inter your Username and Password";
                butLogin.Text = "Login";
                return;
            }
            DataManagementLogin login = new DataManagementLogin();
            data = login.DataLogin(this.textBoxUserName.Text, this.textBoxPassword.Text);



            if (data.Count == 0)
            {
                faildLogin.Visible = true;
                faildLogin.Text = "Login failed check your password and userName";
            }
            else {
                if (this.checkBoxSave.Checked)
                {
                    DataManagementSaveLogin save = new DataManagementSaveLogin();
                    save.SetSave(this.textBoxUserName.Text, this.textBoxPassword.Text);

                }
                else {
                    DataManagementSaveLogin del = new DataManagementSaveLogin();
                    del.deleteSave();
                }
                this.Hide();
                Form mainForm = new Form1();
                mainForm.ShowDialog();
                this.Close();
            }
            butLogin.Text = "Login";
            
        }

        
        
        
    }
}
