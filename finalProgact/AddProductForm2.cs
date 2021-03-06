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
    public partial class AddProductForm2 : Form
    {
        public static AddProductForm2 instance;
        public AddProductForm2()
        {
            InitializeComponent();
            instance = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
                this.tBoxName.Text != "" &&
                this.tBoxManufacturer.Text != "" &&
                this.tBoxlblPrice.Text != "" &&
                this.tBoxQouta.Text != "" 
                )
            {

                this.filldData.Visible = false;



                DataManagementProduct insertData = new DataManagementProduct();
                List<String> d = insertData.InsertData(this.tBoxName.Text, this.tBoxManufacturer.Text, int.Parse(this.tBoxlblPrice.Text), int.Parse(this.tBoxQouta.Text), "Available", lblPathImage.Text);
                
                Form1.instance.ListProduct.Add(d);


                Form1.instance.DGV.Rows.Add(this.tBoxName.Text, this.tBoxManufacturer.Text, this.tBoxlblPrice.Text, this.tBoxQouta.Text, "Available",  Form1.instance.ListProduct.Count()-1,this.lblPathImage.Text);

                this.tBoxName.Text = "" ;
                this.tBoxManufacturer.Text = "" ;
                this.tBoxlblPrice.Text = "" ;
                this.tBoxQouta.Text = "";
                this.lblPathImage.Text = "";
                pictureBox1.Image = Image.FromFile("..\\..\\icons\\addproduct.png");
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

        private void lblUpload_Click(object sender, EventArgs e)
        {

        }

        private void lblAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void tBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxManufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblManufacturer_Click(object sender, EventArgs e)
        {

        }

        private void tBoxlblPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void tBoxQouta_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQouta_Click(object sender, EventArgs e)
        {

        }

        private void lblPathImage_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void filldData_Click(object sender, EventArgs e)
        {

        }

        private void AddProductForm2_Load(object sender, EventArgs e)
        {
            if (Form1.instance.isDark)
            {
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.lblAddProduct.ForeColor = Color.White;
            }
        }

        private void tBoxlblPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tBoxQouta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
