using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqXML
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            XDocument document = new XDocument();
            Product product = new Product(x.Next(), textBox1.Text, float.Parse(textBox2.Text), textBox3.Text, LBlImage.Text);
            Product.Create(product, document);
        }
    }
}
