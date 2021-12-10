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
    public partial class UpdataProduct : Form
    {
        public List<String> ListProduct;
        public UpdataProduct(List<String> l)
        {
            InitializeComponent();
            ListProduct = l;
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

        private void UpdataProduct_Load(object sender, EventArgs e)
        {
            tBoxName.Text = ListProduct[1];
            tBoxManufacturer.Text = ListProduct[2];
            tBoxlblPrice.Text = ListProduct[3];
            tBoxQouta.Text = ListProduct[4];


            lblPathImage.Text = chackPathImage(ListProduct[6]);
            pictureBox1.Image = Image.FromFile(chackPathImage(ListProduct[6]));

            //MessageBox.Show(chackPathImage(ListProduct[6]));
            
            
            if (ListProduct[5] == "Avilable")
            {
                comboBox1.SelectedIndex = 0;
            }
            else {
                comboBox1.SelectedIndex = 1;
            }
           
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
                return "..\\..\\icons\\addproduct.png";
            }
        }
    }
}
