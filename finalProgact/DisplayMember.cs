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
        public int index;
        public int indexTabl;
        public DisplayMember(List<String> l,int i,int it)
        {
            InitializeComponent();
            ListMembers = l;
            index = i;
            indexTabl = it;
        }

        private void filldData_Click(object sender, EventArgs e)
        {

        }

        private void DisplayMember_Load(object sender, EventArgs e)
        {
            if (Form1.instance.isDark)
            {
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.lblAddMember.ForeColor = Color.White;
            }
            tBoxName.Text = ListMembers[1];
            tBoxSurName.Text = ListMembers[2];
            tBoxPhone.Text = ListMembers[3];
            tBoxUserName.Text = ListMembers[5];
            if (ListMembers[5] == "") {
                this.tBoxUserName.Visible = false;
                this.label1.Visible = false;

            }


            
            try
            {
                pictureBox1.Image = Image.FromFile(ListMembers[4]);
                lblPathImage.Text = ListMembers[4];
            }
            catch {
                pictureBox1.Image = Image.FromFile("..\\..\\icons\\members.png");
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

        private void butUpdate_Click(object sender, EventArgs e)
        {


            if (
                this.tBoxName.Text != "" &&
                this.tBoxSurName.Text != "" &&
                this.tBoxPhone.Text != ""
                )
            {
                
                DataManagementMember updataData = new DataManagementMember();
                updataData.UpdateData(int.Parse(ListMembers[0]), tBoxName.Text, tBoxSurName.Text, tBoxPhone.Text, lblPathImage.Text, ListMembers[5].ToString(), ListMembers[6].ToString());

                Form1.instance.ListMembers[0] = new List<string> { ListMembers[0], tBoxName.Text, tBoxSurName.Text, tBoxPhone.Text, lblPathImage.Text ,ListMembers[5].ToString(), ListMembers[6].ToString()};

                DataTable dt = (DataTable)Form1.instance.DGV.DataSource;


                Form1.instance.DGV2.Rows[indexTabl].Cells[1].Value = tBoxName.Text;
                Form1.instance.DGV2.Rows[indexTabl].Cells[2].Value = tBoxSurName.Text;
                Form1.instance.DGV2.Rows[indexTabl].Cells[3].Value = tBoxPhone.Text;

                MessageBox.Show("successful update");
            }
            else
            {
                this.filldData.Visible = true;

            }
        }

        private void butDelet_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show(" Are you sure to delete?", "", MessageBoxButtons.YesNo);

            if (x.ToString() == "Yes")
            {

                DataManagementMember deleteData = new DataManagementMember();
                deleteData.DeleteData(int.Parse(ListMembers[0]));
                Form1.instance.ListMembers.RemoveAt(index);

                Form1.instance.DGV2.Rows.RemoveAt(indexTabl);

                this.Close();
            }
        }
    }
}
