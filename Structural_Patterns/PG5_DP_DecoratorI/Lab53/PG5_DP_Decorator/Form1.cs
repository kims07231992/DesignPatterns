using PG5_DP_Decorator.Bakeryies;
using PG5_DP_Decorator.Bakeryies.Products;
using PG5_DP_Decorator.Bakeryies.Products.Cakes;
using PG5_DP_Decorator.Bakeryies.Products.ProductDecorators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG5_DP_Decorator
{
    public partial class Form1 : Form
    {
        private Bakery _bakery = new Bakery();
        private double _currentPrice;
        private double _currentProductPrice;
        private double _currentToppingPrice;

        public Form1()
        {
            InitializeComponent();
            Form_Load();
        }

        private double CurrentProductPrice
        {
            get { return this._currentProductPrice; }
            set
            {
                this._currentProductPrice = value;
                RefreshCurrentPrice();
            }
        }
        private double CurrentToppingPrice
        {
            get { return this._currentToppingPrice; }
            set
            {
                this._currentToppingPrice = value;
                RefreshCurrentPrice();
            }
        }

        public void Form_Load()
        {
            // show products list
            this.lstProduct.DataSource = this._bakery._productList;
            this.lstProduct.DisplayMember = "Name"; // get Name property
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = this.lstProduct.SelectedItem as Product;

            this.CurrentProductPrice = product == null
                ? 0.00 // if clicked
                : product.Price; // if clicked
        }

        private void chkFruit_CheckedChanged(object sender, EventArgs e)
        {
            var fruit = new FruitTopping();

            // calculate current topping price and update current price
            this.CurrentToppingPrice = this.chkFruit.Checked
                ? this.CurrentToppingPrice + fruit.ToppingPrice // if checked
                : this.CurrentToppingPrice - fruit.ToppingPrice; // if unchecked
        }

        private void chkStatement_CheckedChanged(object sender, EventArgs e)
        {
            var statement = new StatementTopping();

            // calculate current topping price and update current price
            this.CurrentToppingPrice = this.chkStatement.Checked
                ? this.CurrentToppingPrice + statement.ToppingPrice // if checked
                : this.CurrentToppingPrice - statement.ToppingPrice; // if unchecked

            // statement option check
            this.txtStatement.Enabled = this.chkStatement.Checked
                ? true
                : false;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            bool isFruitChecked = this.chkFruit.Checked;
            bool isStatementChecked = this.chkStatement.Checked;
            Product product = this.lstProduct.SelectedItem as Product;
            ProductDecorator decoratedProduct;

            decoratedProduct = new StatementTopping(
                new FruitTopping(product, isFruitChecked), isStatementChecked, this.txtStatement.Text);

            // image show
            var imageList = decoratedProduct.ImageList;
            foreach (var img in imageList)
            {
                var pic = new PictureBox();
                this.pnlImage.Controls.Add(pic);    
                pic.Image = img;
                pic.Location = new Point(0, 0);
                pic.Size = img.Size;
                pic.BringToFront();
            }

            this.txtResult.Text = decoratedProduct.Name;
            this.txtTotalPrice.Text = decoratedProduct.Price.ToString();
        }

        private void RefreshCurrentPrice()
        {
            this._currentPrice = this.CurrentProductPrice + this.CurrentToppingPrice;
            this.txtCurrentPrice.Text = this._currentPrice.ToString();
        }
    }
}
