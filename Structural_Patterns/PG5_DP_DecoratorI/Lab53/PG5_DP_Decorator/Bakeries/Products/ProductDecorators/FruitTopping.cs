using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Decorator.Bakeryies.Products.ProductDecorators
{
    public class FruitTopping : ProductDecorator
    {
        public FruitTopping()
        {
            this.ToppingName = " Fruit";
            this.ToppingPrice = 10.00;
            this.ImagePath = Path.Combine(this.ImagePath,
                @"Bakeries\Products\ProductDecorators\Images\Fruit.jpg");
        }
        public FruitTopping(Product product, bool isChecked) : this()
        {
            this._product = product;
            this._isChecked = isChecked;
        }
    }
}
