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
    public partial class DisplayProfile : Form
    {
        public List<String> ListProfile;
        String index;

        public DisplayProfile(List<String> l)
        {
            InitializeComponent();
            
            ListProfile = l;


        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (
                this.tBoxName.Text != "" &&
                this.tBoxSurName.Text != "" &&
                this.tBoxPhone.Text != ""
                )

            {
                if (this.tBoxPassword.Text.Count() < 3)
                {
                    MessageBox.Show("Username and password longer than 3 characters must be entered");
                    this.filldData.Visible = true;
                    return;
                }
                DataManagementMember updata = new DataManagementMember();
                updata.UpdateData(int.Parse(Form1.instance.ListProfile[0]), tBoxName.Text, tBoxSurName.Text, tBoxPhone.Text, lblPathImage.Text, tBoxUser.Text, tBoxPassword.Text);

                this.filldData.Visible = false;

                Form1.instance.ListProfile = new List<string> { Form1.instance.ListProfile[0], tBoxName.Text, tBoxSurName.Text, tBoxPhone.Text, lblPathImage.Text,index, tBoxUser.Text, tBoxPassword.Text };

                MessageBox.Show("successful update");
            }
            else
            {
                this.filldData.Visible = true;

            }
        }

        private void DisplayProfile_Load(object sender, EventArgs e)
        {
            if (Form1.instance.isDark)
            {
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.lblAddMember.ForeColor = Color.White;
            }
            
            tBoxName.Text = ListProfile[1];
            tBoxSurName.Text = ListProfile[2];
            tBoxPhone.Text = ListProfile[3];
            index = ListProfile[5];
            tBoxUser.Text = ListProfile[6];
            tBoxPassword.Text = ListProfile[7];


            try {
                pictureBox1.Image = Image.FromFile( ListProfile[4]);
                // image file path  
                lblPathImage.Text = ListProfile[4];
            }
            catch {
                pictureBox1.Image = Image.FromFile("..\\..\\icons\\members.png");
                // image file path  
                lblPathImage.Text = "..\\..\\icons\\members.png";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
