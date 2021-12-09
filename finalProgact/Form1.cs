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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView2.Rows.Insert(0, "one", "two", "three", "four");
            List<string> listProduct = new List<string>()
                {
                    "John Doe",
                    "Jane Doe",
                    "Joe Doe"
                };

            
            var mbox = new finalProgact.ListPrductClass2();
            List<List<string>> myList = mbox.myList;
            mbox.myList.Add(new List<string> { "1", "Asus F15", " ASUS", "900", "20", "Avilable" });

            for (int i = 0; i < myList.Count; i++) 
            {
                this.dataGridView2.Rows.Add(myList[i][1], myList[i][2], myList[i][3], myList[i][4],myList[i][5]);
            }

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form addForm = new AddProductForm2();
            addForm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form addForm = new AddMemberForm3();
            addForm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form addForm = new SellProductsForm4();
            addForm.ShowDialog();
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
    }
}
