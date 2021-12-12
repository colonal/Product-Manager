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
        public SellProductsForm4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void SellProductsForm4_Load(object sender, EventArgs e)
        {
            List<List<string>> p = Form1.instance.ListProduct;

            foreach (List<string> i in p)
            {
                this.comBoxProduct.Items.Add(i[1]);
            }

            List<List<string>> m = Form1.instance.ListMembers;

            foreach (List<string> i in m)
            {
                this.comBoxMember.Items.Add(i[1]);
            }

            this.comBoxProduct.SelectedIndex = 0;
            this.comBoxMember.SelectedIndex = 0;


            
        }

        private void comBoxProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            var select = comBoxProduct.SelectedItem.ToString();

            List<List<string>> p = Form1.instance.ListProduct;

            this.comQuantity.Items.Clear();
            foreach (List<string> I in p)
            {
                if (select == I[1]) {

                    for (int i = 1; i <= int.Parse(I[4]); i = i + 1)
                    {
                        this.comQuantity.Items.Add(i.ToString());
                    }
                    break;
                    
                }
                
            }
            this.comQuantity.SelectedIndex = 0;
        }
    }
}
