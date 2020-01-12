using PG5_DP_Decorator.Bakeryies.Products;
using PG5_DP_Decorator.Bakeryies.Products.Cakes;
using PG5_DP_Decorator.Bakeryies.Products.ProductDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Decorator.Bakeryies
{
    public class Bakery
    {
        public List<Product> _productList = new List<Product>() {
            new Cake1(), new Cake2()
        }; // products list, need to be changed using database
        public List<ProductDecorator> _toppingList = new List<ProductDecorator>() {
           new FruitTopping(), new StatementTopping() 
        }; // toppings list, need to be changed using database
    }
}
