using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BakeryProj
{
    public partial class Form1 : Form
    {
        List<string> products = new List<string>();
        Dictionary<string, string> prods = new Dictionary<string, string>();
        
        public Form1()
        {
            InitializeComponent();
            //FillDropdown();
        }

        //private void FillDropdown()
        //{
        //    prods.Add("Vegemite Scroll", "VS5");
        //    prods.Add("Blueberry Muffin", "MB11");
        //    prods.Add("Croissant", "CF");

        //    products.Add("Vegemite Scroll");
        //    products.Add("Blueberry Muffin");
        //    products.Add("Croissant");

        //    comboBox1.DataSource = products;
            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            List<string> finaloutput = new List<string>();

            IProduct prod = null;

            ProductFactory pf = new ProductFactory();
            if (textBox2.Text != string.Empty)
            {
                finaloutput.Add("Vegemite Scroll");
                finaloutput.Add("-------------");
                prod = pf.GetProduct("VS5");
                var lst = prod.Calculate(Convert.ToInt32(textBox2.Text));
                lst.RemoveAt(lst.Count() - 1);
                finaloutput.AddRange(lst);
                finaloutput.Add("-------------");
            }
            if (textBox3.Text != string.Empty)
            {
                finaloutput.Add("Blackberry Muffin");
                finaloutput.Add("-------------");
                prod = pf.GetProduct("MB11");
                var lst = prod.Calculate(Convert.ToInt32(textBox3.Text));
                lst.RemoveAt(lst.Count() - 1);
                finaloutput.AddRange(lst);
                finaloutput.Add("-------------");
            }
            if (textBox4.Text != string.Empty)
            {
                finaloutput.Add("Croissant");
                finaloutput.Add("-------------");
                prod = pf.GetProduct("CF");
                var lst = prod.Calculate(Convert.ToInt32(textBox4.Text));
                lst.RemoveAt(lst.Count() - 1);
                finaloutput.AddRange(lst);
            }

            if (finaloutput.Count() == 0)
            {
                textBox1.Text = "Please add the proper quantity as per the packs available";
                return;
            }
            string joinedList = string.Join(Environment.NewLine, finaloutput);
            textBox1.Text = joinedList; //string.Join(Environment.NewLine, textBox1, joinedList);

           if (joinedList == string.Empty)
           {
               textBox1.Text = "Please add the proper quantity as per the packs available";
           }
           //textBox1.Text= prod.Calculate(Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
}
