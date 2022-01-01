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
    public partial class SeellConfirmForm5 : Form
    {
        String product;
        String member;
        String quantity;
        int Id;
        int price;
        int index;
        public SeellConfirmForm5(String Product, String Member, String Quantity, int ID, int Index)
        {
            InitializeComponent();
            product = Product;
            member = Member;
            quantity = Quantity;
            Id = ID;
            index = Index;
        }

        private void SeellConfirmForm5_Load(object sender, EventArgs e)
        {
            if (Form1.instance.isDark)
            {
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.lblAddProduct.ForeColor = Color.White;
            }
            ProductLab.Text = product;
            MemberLab.Text = member;
            // "{price[0]}X{quantity} = {price[0]*quantity}"
            DataManagementSellings getPrice = new DataManagementSellings();
            price = getPrice.GetPrice(Id);
            QuantityLab.Text = String.Format("{0}X{1} = {2}", price, quantity, price * int.Parse(quantity));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataManagementSellings insertDatat = new DataManagementSellings();
            int idMember = int.Parse(Form1.instance.ListProfile[0]);

            int newQouta = int.Parse(Form1.instance.ListProduct[index][4]) - int.Parse( quantity);

           insertDatat.InserConfirm(product, Id, member, idMember, int.Parse(quantity), price * int.Parse(quantity));

            
            Form1.instance.ListProduct[index][4] = newQouta.ToString();
            Form1.instance.DGV.Rows.Clear();

            for (int i = 0; i < Form1.instance.ListProduct.Count; i++)
            {
                Form1.instance.DGV.Rows.Add(Form1.instance.ListProduct[i][1], Form1.instance.ListProduct[i][2], Form1.instance.ListProduct[i][3], Form1.instance.ListProduct[i][4], Form1.instance.ListProduct[i][5], i, Form1.instance.ListProduct[0]);
            }
            MessageBox.Show("Confirm Success");
            this.Close();
        }
    }
}
