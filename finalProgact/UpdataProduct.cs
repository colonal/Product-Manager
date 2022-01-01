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
        public int index;
        public int indexTabl;
        public UpdataProduct(List<String> l, int i, int it)
        {
            InitializeComponent();
            ListProduct = l;
            index = i;
            indexTabl = it;
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
            if (Form1.instance.isDark)
            {
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.lblAddProduct.ForeColor = Color.White;
            }
            tBoxName.Text = ListProduct[1];
            tBoxManufacturer.Text = ListProduct[2];
            tBoxlblPrice.Text = ListProduct[3];
            tBoxQouta.Text = ListProduct[4];

            try
            {
                pictureBox1.Image = Image.FromFile(ListProduct[6]);
                lblPathImage.Text = ListProduct[6];

            }
            catch
            {
                pictureBox1.Image = Image.FromFile("..\\..\\icons\\addproduct.png");
                lblPathImage.Text = "..\\..\\icons\\addproduct.png";

            }



            if (ListProduct[5] == "Available")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }

        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (
                this.tBoxName.Text != "" &&
                this.tBoxManufacturer.Text != "" &&
                this.tBoxlblPrice.Text != "" &&
                this.tBoxQouta.Text != ""
                )
            {


                DataManagementProduct updateData = new DataManagementProduct();
                updateData.UpdateData(int.Parse(ListProduct[0]), tBoxName.Text, tBoxManufacturer.Text, int.Parse(tBoxlblPrice.Text), int.Parse(tBoxQouta.Text), comboBox1.SelectedItem.ToString(), lblPathImage.Text);

                Form1.instance.ListProduct[index] = new List<string> { ListProduct[0], tBoxName.Text, tBoxManufacturer.Text, tBoxlblPrice.Text, tBoxQouta.Text, comboBox1.SelectedItem.ToString(), lblPathImage.Text };

                DataTable dt = (DataTable)Form1.instance.DGV.DataSource;


                Form1.instance.DGV.Rows[indexTabl].Cells[0].Value = tBoxName.Text;
                Form1.instance.DGV.Rows[indexTabl].Cells[1].Value = tBoxManufacturer.Text;
                Form1.instance.DGV.Rows[indexTabl].Cells[2].Value = tBoxlblPrice.Text;
                Form1.instance.DGV.Rows[indexTabl].Cells[3].Value = tBoxQouta.Text;
                Form1.instance.DGV.Rows[indexTabl].Cells[4].Value = comboBox1.SelectedItem.ToString();

                MessageBox.Show("successful update");
            }
            else
            {
                this.filldData.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {




            var x = MessageBox.Show(" Are you sure to delete?" , "", MessageBoxButtons.YesNo);

            if (x.ToString() == "Yes")
            {

                DataManagementProduct deleteData = new DataManagementProduct();
                deleteData.DeleteData(int.Parse(ListProduct[0]));
                Form1.instance.ListProduct.RemoveAt(index);

                Form1.instance.DGV.Rows.RemoveAt(indexTabl);

                this.Close();
            }

        }

        private void tBoxlblPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; 
                if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                            {
                    e.Handled =  true;
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
