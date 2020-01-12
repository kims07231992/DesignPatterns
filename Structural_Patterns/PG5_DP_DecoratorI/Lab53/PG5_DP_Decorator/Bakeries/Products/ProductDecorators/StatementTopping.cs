using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Decorator.Bakeryies.Products.ProductDecorators
{
    public class StatementTopping : ProductDecorator
    {
        public StatementTopping()
        {
            this.ToppingPrice = 12.00;
            this.ImagePath = Path.Combine(this.ImagePath,
                @"Bakeries\Products\ProductDecorators\Images\HappyBirthday.jpg");
        }
        public StatementTopping(Product product, bool isChecked, string statement) : this()
        {
            this._product = product;
            this.ToppingName = " " + statement;
            this._isChecked = isChecked;
        }
    }
}
