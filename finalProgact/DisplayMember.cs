using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace finalProgact
{
    public partial class DisplayMember : Form
    {
        public List<String> ListMembers;
        public DisplayMember(List<String> l)
        {
            InitializeComponent();
            ListMembers = l;
        }

        private void filldData_Click(object sender, EventArgs e)
        {

        }

        private void DisplayMember_Load(object sender, EventArgs e)
        {

            tBoxName.Text = ListMembers[1];
            tBoxSurName.Text = ListMembers[2];
            tBoxPhone.Text = ListMembers[3];
            


            lblPathImage.Text = chackPathImage(ListMembers[4]);
            pictureBox1.Image = Image.FromFile(chackPathImage(ListMembers[4]));
        }
        static String chackPathImage(String path)
        {
            try
            {
                using (Stream stream = new FileStream(path, FileMode.Open))
                {
                    // File/Stream manipulating code here
                    return path;
                }
            }
            catch
            {
                //check here why it failed and ask user to retry if the file is in use.
                return "..\\..\\icons\\members.png";
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
