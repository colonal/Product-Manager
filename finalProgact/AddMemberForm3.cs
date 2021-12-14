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

                this.filldData.Visible = false;



                Form1.instance.ListMembers.Add(new List<string> { "1", this.tBoxName.Text, this.tBoxSurName.Text, this.tBoxPhone.Text, this.lblPathImage.Text });

                Form1.instance.DGV2.Rows.Add("3",this.tBoxName.Text, this.tBoxSurName.Text, this.tBoxPhone.Text,Form1.instance.ListMembers.Count()-1);

                this.tBoxName.Text = "";
                this.tBoxSurName.Text = "";
                this.tBoxPhone.Text = "";

                pictureBox1.Image = Image.FromFile("..\\..\\icons\\addmember.png");
            }
            else
            {
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
    }
}
