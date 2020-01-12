using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Decorator.Bakeryies.Products
{
    public abstract class Product
    {
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual List<Image> ImageList { get; } = new List<Image>();

        public string ImagePath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
    }
}
