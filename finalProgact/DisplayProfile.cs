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


        public DisplayProfile(List<String> l)
        {
            InitializeComponent();
            
            ListProfile = l;


        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            // "2", "Ali", " ss", "+95355324", "C:\\Users\\user\\Pictures\\3.jpg"
            if (
                this.tBoxName.Text != "" &&
                this.tBoxSurName.Text != "" &&
                this.tBoxPhone.Text != ""
                )

            {
                this.filldData.Visible = false;

                Form1.instance.ListProfile = new List<string> { Form1.instance.ListProfile[0], tBoxName.Text, tBoxSurName.Text, tBoxPhone.Text, lblPathImage.Text };
                
                //Form1.instance.ListMembers[index] = new List<String> { Form1.instance.ListProfile[0], tBoxName.Text, tBoxSurName.Text, tBoxPhone.Text, lblPathImage.Text };

                //Form1.instance.DGV2.Rows[indexTabl].Cells[1].Value = tBoxName.Text;
                //Form1.instance.DGV2.Rows[indexTabl].Cells[2].Value = tBoxSurName.Text;
                //Form1.instance.DGV2.Rows[indexTabl].Cells[3].Value = tBoxPhone.Text;



                MessageBox.Show("successful update");
            }
            else
            {
                this.filldData.Visible = true;

            }
        }

        private void DisplayProfile_Load(object sender, EventArgs e)
        {
            tBoxName.Text = ListProfile[1];
            tBoxSurName.Text = ListProfile[2];
            tBoxPhone.Text = ListProfile[3];

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
    }
}
