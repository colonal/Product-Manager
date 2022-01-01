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
    public partial class SellProductsForm4 : Form
    {
        int index = 0;
        public SellProductsForm4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(index != -1){
                this.Hide();
                SeellConfirmForm5 confirm = new SeellConfirmForm5(comBoxProduct.SelectedItem.ToString(), labMember.Text, comQuantity.SelectedItem.ToString(), int.Parse(Form1.instance.ListProduct[index][0]), index); //int.Parse(Form1.instance.ListProduct[index][0])
                confirm.ShowDialog();
            }
        }

        private void SellProductsForm4_Load(object sender, EventArgs e)
        {
            if (Form1.instance.isDark)
            {
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#4d4d4d");
                this.lblAddProduct.ForeColor = Color.White;
            }
            List<List<string>> p = Form1.instance.ListProduct;

            foreach (List<string> i in p)
            {
                this.comBoxProduct.Items.Add(i[1]);
            }

            

            labMember.Text = Form1.instance.ListProfile[1];


            try
            {
                this.comBoxProduct.SelectedIndex = 0;
            }
            catch {
                index = -1;
            }


            
        }

        private void comBoxProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            var select = comBoxProduct.SelectedItem.ToString();
            index = comBoxProduct.SelectedIndex;
            List<List<string>> p = Form1.instance.ListProduct;

            this.comQuantity.Items.Clear();
            

            for (int i = 1; i <= int.Parse(p[index][4].ToString()); i = i + 1)
                    {
                        this.comQuantity.Items.Add(i.ToString());
                    }
                    
            this.comQuantity.SelectedIndex = 0;
        }

        
    }
}
