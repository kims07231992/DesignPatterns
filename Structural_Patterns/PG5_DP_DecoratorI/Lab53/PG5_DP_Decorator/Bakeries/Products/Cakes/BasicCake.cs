using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Decorator.Bakeryies.Products.Cakes
{
    public abstract class BasicCake : Product
    {
        public BasicCake()
        {
            this.ImagePath = Path.Combine(this.ImagePath, @"Bakeries\Products\Cakes\Images\Cake.jpg");
            this.ImageList.Add(Image.FromFile(this.ImagePath));
        }
    }
}
