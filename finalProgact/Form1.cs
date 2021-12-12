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
    public partial class Form1 : Form
    {
        public static  Form1 instance;
        public List<List<string>> ListProduct = new List<List<string>>();
        public List<List<string>> ListMembers = new List<List<string>>();
        public DataGridView DGV;
        public DataGridView DGV2;

        List<String> ListImage = new List<string>();
        public Form1()
        {
            
            InitializeComponent();
            instance = this;
            List<List<string>> listProduct2 = ListProduct;
            List<List<string>> ListMembers2 = ListMembers;
            
            DGV = this.dataGridView2;
            DGV2 = this.dataGridView1;

            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            //this.dataGridView2.Rows.Insert(0, "one", "two", "three", "four");
            //this.pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Pictures\\1.jpeg");


            ListProduct.Add(new List<string> { "1", "Asus F15", " ASUS", "900", "20", "Avilable", "C:\\Users\\user\\Pictures\\2.jpg" });
            ListProduct.Add(new List<string> { "2", "Iphon 8", "Apple", " 700", "10", "Avilable", "C:\\Users\\user\\Pictures\\3.jpg" });
            ListProduct.Add(new List<string> { "2", "Iphon 9", "Apple", " 800", "15", "Avilable", "C:\\Users\\user\\Pictures\\2.jpg" });

            for (int i = 0; i < ListProduct.Count; i++) 
            {
                this.dataGridView2.Rows.Add(ListProduct[i][1], ListProduct[i][2], ListProduct[i][3], ListProduct[i][4], ListProduct[i][5],i);
            }


            ListMembers.Add(new List<string> { "1", "mohammad", " cc", "+9555544", "C:\\Users\\user\\Pictures\\2.jpg" });
            ListMembers.Add(new List<string> { "2", "Ali", " ss", "+95355324", "C:\\Users\\user\\Pictures\\3.jpg" });

            for (int i = 0; i < ListMembers.Count; i++)
            {
                this.dataGridView1.Rows.Add(ListProduct[i][0], ListProduct[i][1], ListProduct[i][2], ListProduct[i][3],i);
            }
            


        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form addForm = new AddProductForm2();
            addForm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form AddMember = new AddMemberForm3();
            AddMember.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form SellProducts = new SellProductsForm4();
            SellProducts.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2_Prosses();
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            //dataGridView2_Prosses();
        }
        private void dataGridView2_Prosses() {

            if (dataGridView2.CurrentCell.RowIndex < ListProduct.Count)
            {

                MessageBox.Show(" List index:" + dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["indexP"].Value.ToString() + " RowIndex:" + dataGridView2.CurrentCell.RowIndex.ToString());
                string index = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["indexP"].Value.ToString();
                Form editProduct = new UpdataProduct(ListProduct[int.Parse(index)]);
                editProduct.ShowDialog();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1_Prosses();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //dataGridView1_Prosses();
        }

        private void dataGridView1_Prosses()
        {

            if (dataGridView1.CurrentCell.RowIndex < ListMembers.Count)
            {

                MessageBox.Show(" List index:" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["indexM"].Value.ToString() + " RowIndex:" + dataGridView1.CurrentCell.RowIndex.ToString());
                string index = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["indexM"].Value.ToString();
                Form displayMember = new DisplayMember(ListProduct[int.Parse(index)]);
                displayMember.ShowDialog();
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (dataGridView2.CurrentCell.RowIndex < ListProduct.Count)
            {
                string index = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["indexP"].Value.ToString();
                String checkImage = chackPathImage(ListProduct[int.Parse(index)][6]);
                
                if (checkImage != "")
                    this.pictureBox1.Image = Image.FromFile(checkImage);
                //MessageBox.Show(ListProduct[int.Parse(index)][6]);
            }
        }



        private String chackPathImage(String path)
        {

            if (ListImage.Contains(path) == false)
            {
                try
                {
                    using (Stream stream = new FileStream(path, FileMode.Open))
                    {
                        // File/Stream manipulating code here
                        ListImage.Add(path);
                        return path;
                    }
                }
                catch
                {
                    //check here why it failed and ask user to retry if the file is in use.
                    return "";
                }
            }
            return path;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex < ListMembers.Count)
            {
                string index = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["indexM"].Value.ToString();
                String checkImage = chackPathImage(ListMembers[int.Parse(index)][4]);

                if (checkImage != "")
                    this.pictureBox2.Image = Image.FromFile(checkImage);
                //MessageBox.Show(ListProduct[int.Parse(index)][6]);
            }

        }

        

        

        
        
    }

    
}
