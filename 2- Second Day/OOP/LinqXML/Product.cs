using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqXML
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Product()
        {

        }
        public Product(int Id,string Name , float Price , string Description , string Image)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Image = Image; ;
            this.Description = Description;
        }

        public static bool Create(Product p ,XDocument document)
        {
            document.Add(p);
            document.Save(Directory.GetCurrentDirectory() + "/Product.xml");
            return true;

        }
    }
}
