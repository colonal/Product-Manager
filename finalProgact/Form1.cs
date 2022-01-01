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
        public List<string> ListProfile = new List<string>();
        public DataGridView DGV;
        public DataGridView DGV2;
        public int indexProfile = -999;

        List<String> ListImage = new List<string>();

        public bool isDark = false;
        public Form1()
        {
            
            InitializeComponent();
            instance = this;
            
            DGV = this.dataGridView2;
            DGV2 = this.dataGridView1;

            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            runQuery r = new runQuery();
            //r.resetData();

            ListProfile = LoginForm.instance.data;

            DataManagementSellings SellingsData = new DataManagementSellings();
            List<String> sellingsData = SellingsData.GetData();

            TotalProductLab.Text = sellingsData[0];
            TotalMemberLab.Text = sellingsData[1];
            SoldProductsLab.Text = sellingsData[2] != "" ? sellingsData[2] : "0";
            TotalAmountLab.Text = sellingsData[3] != "" ? sellingsData[3] + " $" : "0 $";

            DataManagementProduct DBP = new DataManagementProduct();
            List<List<String>> dataListP =  DBP.SelectData();

            ListProduct = dataListP;

            DataManagementMember DBM = new DataManagementMember();
            List<List<String>> dataListM = DBM.SelectData();

            ListMembers = dataListM;
            if(ListProfile[5] != "Admin"){
                toolStripButton2.Visible = false;
                tabControl1.TabPages.Remove(tabMember);
            };
            
      
            

            for (int i = 0; i < ListProduct.Count; i++) 
            {
                this.dataGridView2.Rows.Add(ListProduct[i][1], ListProduct[i][2], ListProduct[i][3], ListProduct[i][4], ListProduct[i][5],i, ListProduct[0]);
            }

            for (int i = 0; i < ListMembers.Count; i++)
            {
                if (ListMembers[i][0] == ListProfile[0]) 
                {
                    indexProfile = i;
                    
                    ListProfile = new List<String> { ListMembers[i][0], ListMembers[i][1], ListMembers[i][2], ListMembers[i][3], ListMembers[i][4], i.ToString(), ListMembers[i][5], ListMembers[i][6] };
                }else
                    this.dataGridView1.Rows.Add(ListMembers[i][0], ListMembers[i][1], ListMembers[i][2], ListMembers[i][3], i);
            }

            try
            {
                pictureProfile.Image = Image.FromFile(ListProfile[4]);
            }
            catch {
                pictureProfile.Image = Image.FromFile("..\\..\\icons\\members.png");
            }
            nameProfil.Text = ListProfile[1] + " "+ ListProfile[2];
            phoneProfile.Text =  ListProfile[3];
            usernameProfil.Text = ListProfile[6];

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
            DataManagementSellings SellingsData = new DataManagementSellings();
            List<String> sellingsData = SellingsData.GetData();

            TotalProductLab.Text = sellingsData[0];
            TotalMemberLab.Text = sellingsData[1];
            SoldProductsLab.Text = sellingsData[2] != "" ? sellingsData[2] : "0";
            TotalAmountLab.Text = sellingsData[3] != "" ? sellingsData[3] + " $" : "0 $";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("textBox1_TextChanged");
            DataManagementProduct DBP = new DataManagementProduct();
            List<List<String>> searchData = DBP.SerchProdect(txtBoxSearch.Text);
            ListProduct = searchData;
            this.dataGridView2.Rows.Clear();
            for (int i = 0; i < ListProduct.Count; i++)
            {
                this.dataGridView2.Rows.Add(ListProduct[i][1], ListProduct[i][2], ListProduct[i][3], ListProduct[i][4], ListProduct[i][5], i, ListProduct[0]);
            }
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
        }
        private void dataGridView2_Prosses() {

            if (dataGridView2.CurrentCell.RowIndex < ListProduct.Count)
            {

                
                string index = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["indexP"].Value.ToString();
                Form editProduct = new UpdataProduct(ListProduct[int.Parse(index)], int.Parse(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["indexP"].Value.ToString()), int.Parse(dataGridView2.CurrentCell.RowIndex.ToString()));
                editProduct.ShowDialog();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1_Prosses();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dataGridView1_Prosses()
        {

            if (dataGridView1.CurrentCell.RowIndex < ListMembers.Count - 1)
            {

                
                string index = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["indexM"].Value.ToString();
                Form displayMember = new DisplayMember(ListMembers[int.Parse(index)], int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["indexM"].Value.ToString()), int.Parse(dataGridView1.CurrentCell.RowIndex.ToString()));
                displayMember.ShowDialog();
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (dataGridView2.CurrentCell.RowIndex < ListProduct.Count)
            {
                string index = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["indexP"].Value.ToString();

                try {
                    this.pictureBox1.Image = Image.FromFile(ListProduct[int.Parse(index)][6]);
                }
                catch {
                    this.pictureBox1.Image = Image.FromFile("..\\..\\icons\\addproduct.png");
                }
            }
        }



        private String chackPathImage1(String path)
        {
            if (ListImage.Contains(path) == false)
            {
                try
                {
                    using (Stream stream = new FileStream(path, FileMode.Open))
                    {
                        // File/Stream manipulating code here
                        ListImage.Add(path);
                        stream.Close();
                        return path;
                    }
                    
                }
                catch
                {
                    return "";
                }
            }
            return path;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex < ListMembers.Count -1 )
            {
                string index = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["indexM"].Value.ToString();

                try {
                    this.pictureBox2.Image = Image.FromFile(ListMembers[int.Parse(index)][4]);
                }
                catch {
                    this.pictureBox2.Image = Image.FromFile("..\\..\\icons\\members.png");
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginF = new LoginForm();
            loginF.ShowDialog();
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginF = new LoginForm();
            loginF.ShowDialog();
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Form displayMember = new DisplayProfile(ListProfile);
            displayMember.ShowDialog();

            Console.WriteLine("indexProfile: " + indexProfile);
            try
            {
                pictureProfile.Image = Image.FromFile(ListProfile[4]);
            }catch{
                pictureProfile.Image = Image.FromFile("..\\..\\icons\\members.png");
            }
            nameProfil.Text =  ListProfile[1] + ListProfile[2];
            phoneProfile.Text = ListProfile[3];



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("textBox1_TextChanged");
            DataManagementProduct DBP = new DataManagementProduct();
            List<List<String>> searchData = DBP.SerchProdect(txtBoxSearch.Text);
            ListProduct = searchData;
            this.dataGridView2.Rows.Clear();
            for (int i = 0; i < ListProduct.Count; i++)
            {
                this.dataGridView2.Rows.Add(ListProduct[i][1], ListProduct[i][2], ListProduct[i][3], ListProduct[i][4], ListProduct[i][5], i, ListProduct[0]);
            }

        }




        public void CangeRadiosAvailable(object sender, EventArgs e)
        {

            DataManagementProduct DBP = new DataManagementProduct();
            List<List<String>> searchData;
            if (radioButton3.Checked)
            {
                searchData = DBP.SerchAvailabitity(0);
            }
            else if (radioButton2.Checked)
            {
                 searchData = DBP.SerchAvailabitity(1);
            }
            else
            {
                searchData = DBP.SerchAvailabitity(3);
            }
            
            
            ListProduct = searchData;
            this.dataGridView2.Rows.Clear();
            for (int i = 0; i < ListProduct.Count; i++)
            {
                this.dataGridView2.Rows.Add(ListProduct[i][1], ListProduct[i][2], ListProduct[i][3], ListProduct[i][4], ListProduct[i][5], i, ListProduct[0]);
            }
        
        }

        private void CangeRadiosAvailable()
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (!isDark)
            {
                isDark = true;
                this.toolStripButtonMood.Image = global::finalProgact.Properties.Resources.white_balance;
                this.BackColor = ColorTranslator.FromHtml("#626262");
                this.toolStrip1.BackColor = ColorTranslator.FromHtml("#626262");
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#626262");
                this.tabProduct.BackColor = ColorTranslator.FromHtml("#626262");
                this.tabMember.BackColor = ColorTranslator.FromHtml("#626262");
                this.tabSell.BackColor = ColorTranslator.FromHtml("#626262");
                this.tabProfile.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView2.ForeColor = Color.White;
                this.dataGridView2.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView2.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView2.Columns[2].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView2.Columns[3].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView2.Columns[4].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.tabProduct.ForeColor = ColorTranslator.FromHtml("#626262");
                this.tabMember.ForeColor = ColorTranslator.FromHtml("#626262");
                this.tabSell.ForeColor = ColorTranslator.FromHtml("#626262");
                this.tabProfile.ForeColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView1.ForeColor = Color.White;
                this.dataGridView1.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView1.Columns[1].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView1.Columns[2].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.dataGridView1.Columns[3].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#626262");
                this.toolStripButton1.ForeColor = Color.White;
                this.toolStripButton2.ForeColor = Color.White;
                this.toolStripButton3.ForeColor = Color.White;
                this.toolStripButton4.ForeColor = Color.White;
                this.toolStripButton5.ForeColor = Color.White;
                this.toolStripButtonMood.ForeColor = Color.White;
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.tabProfile.BackColor = ColorTranslator.FromHtml("#4d4d4d");
            }
            else {
                isDark = false;
                this.toolStripButtonMood.Image = global::finalProgact.Properties.Resources.night_mode;
                this.BackColor = Color.White;
                this.toolStrip1.BackColor = Color.White;
                this.groupBox1.BackColor = Color.White;
                this.tabProduct.BackColor = Color.White;
                this.tabMember.BackColor = Color.White;
                this.tabSell.BackColor = Color.White;
                this.dataGridView2.ForeColor = Color.Black;
                this.dataGridView2.Columns[0].DefaultCellStyle.BackColor = Color.White;
                this.dataGridView2.Columns[1].DefaultCellStyle.BackColor = Color.White;
                this.dataGridView2.Columns[2].DefaultCellStyle.BackColor = Color.White;
                this.dataGridView2.Columns[3].DefaultCellStyle.BackColor = Color.White;
                this.dataGridView2.Columns[4].DefaultCellStyle.BackColor = Color.White;
                this.tabProduct.ForeColor = Color.White;
                this.tabMember.ForeColor = Color.White;
                this.tabSell.ForeColor = Color.White;
                this.tabProfile.ForeColor = Color.White;
                this.dataGridView1.ForeColor = Color.Black;
                this.dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.White;
                this.dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.White;
                this.dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.White;
                this.dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.White;
                this.toolStripButton1.ForeColor = Color.Black;
                this.toolStripButton2.ForeColor = Color.Black;
                this.toolStripButton3.ForeColor = Color.Black;
                this.toolStripButton4.ForeColor = Color.Black;
                this.toolStripButton5.ForeColor = Color.Black;
                this.toolStripButtonMood.ForeColor = Color.Black;
                this.groupBox2.ForeColor = Color.Black;
                this.groupBox4.ForeColor = Color.Black;
                this.groupBox8.ForeColor = Color.Black;
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#696969");
                this.tabProfile.BackColor = ColorTranslator.FromHtml("#696969");
            
            
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("textBox2_TextChanged");
            DataManagementMember DBP = new DataManagementMember();
            List<List<String>> searchData = DBP.SerchMember(textBoxSearchMumber.Text);
            ListMembers = searchData;
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < ListMembers.Count; i++)
            {
                if (ListMembers[i][0] != ListProfile[0])
                    this.dataGridView1.Rows.Add(ListMembers[i][0], ListMembers[i][1], ListMembers[i][2], ListMembers[i][3], i);
                
                    
            }
        }     
        
    }
    
}
