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
    public partial class AddMemberForm3 : Form
    {
        public AddMemberForm3()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
                this.tBoxName.Text != "" &&
                this.tBoxSurName.Text != "" &&
                this.tBoxPhone.Text != "" 

                
                )
            {
                if (checkBox1.Checked) {
                    if (this.tBoxPassword.Text.Count() < 3 && this.tBoxUserName.Text.Count() < 3)
                    {
                        MessageBox.Show( "Username and password longer than 3 characters must be entered");
                        this.filldData.Visible = true;
                        return;
                    }
                }

                this.filldData.Visible = false;

                DataManagementMember inserData = new DataManagementMember();
                List<String> d = inserData.InsertData(this.tBoxName.Text, this.tBoxSurName.Text, this.tBoxPhone.Text, this.lblPathImage.Text, this.tBoxUserName.Text,this.tBoxPassword.Text);


                if (d.Count == 0) {
                    return;
                }

                Form1.instance.ListMembers.Add(d);
                String index = Form1.instance.ListMembers[Form1.instance.ListMembers.Count - 1].ToString();
               
                Form1.instance.DGV2.Rows.Add(Form1.instance.ListMembers[Form1.instance.ListMembers.Count - 1][0], this.tBoxName.Text, this.tBoxSurName.Text, this.tBoxPhone.Text, Form1.instance.ListMembers.Count - 1);

                this.tBoxName.Text = "";
                this.tBoxSurName.Text = "";
                this.tBoxPhone.Text = "";
                this.tBoxPassword.Text = "";
                this.tBoxUserName.Text = "";

                pictureBox1.Image = Image.FromFile("..\\..\\icons\\addmember.png");
            }
            else
            {
                this.filldData.Text = "All data must be filled out";
                this.filldData.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                lblPathImage.Text = open.FileName;

            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.tBoxUserName.Enabled = true;
                this.tBoxPassword.Enabled = true;

                
            }
            else {

                this.tBoxUserName.Enabled = false;
                this.tBoxPassword.Enabled = false;
                this.tBoxUserName.Text = "";
                this.tBoxPassword.Text = "";
            }
        }

        private void AddMemberForm3_Load(object sender, EventArgs e)
        {
            if (Form1.instance.isDark) {
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.lblAddMember.ForeColor = Color.White;
            }
        }
    }
}
