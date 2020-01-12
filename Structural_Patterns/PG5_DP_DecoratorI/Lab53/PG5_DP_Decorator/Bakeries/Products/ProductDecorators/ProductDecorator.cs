using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Decorator.Bakeryies.Products.ProductDecorators
{
    public abstract class ProductDecorator : Product
    {
        protected Product _product;
        protected bool _isChecked;

        public override string Name
        {
            get
            {
                return this._isChecked
                    ? this._product.Name + this.ToppingName
                    : this._product.Name;
            }
        }
        public override double Price
        {
            get
            {
                return this._isChecked
                    ? this._product.Price + this.ToppingPrice
                    : this._product.Price;
            }
        }
        public override List<Image> ImageList
        {
            get
            {
                if (this._isChecked)
                {
                    this._product.ImageList.Add(Image.FromFile(this.ImagePath));                 
                }
                return this._product.ImageList;
            }
        }

        public string ToppingName { get; protected set; } // to show Topping name
        public double ToppingPrice { get; protected set; } // tow show Topping price
    }
}
