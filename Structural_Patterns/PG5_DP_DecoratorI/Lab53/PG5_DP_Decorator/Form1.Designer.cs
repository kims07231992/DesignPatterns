namespace PG5_DP_Decorator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlTopping = new System.Windows.Forms.Panel();
            this.chkFruit = new System.Windows.Forms.CheckBox();
            this.chkStatement = new System.Windows.Forms.CheckBox();
            this.lblTopping = new System.Windows.Forms.Label();
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblStatement = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblImage = new System.Windows.Forms.Label();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lblResultStatement = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlProduct.SuspendLayout();
            this.pnlTopping.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 15;
            this.lstProduct.Location = new System.Drawing.Point(3, 31);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(140, 169);
            this.lstProduct.TabIndex = 1;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Location = new System.Drawing.Point(78, 35);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.Size = new System.Drawing.Size(221, 25);
            this.txtCurrentPrice.TabIndex = 2;
            // 
            // pnlProduct
            // 
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduct.Controls.Add(this.lblProduct);
            this.pnlProduct.Controls.Add(this.lstProduct);
            this.pnlProduct.Location = new System.Drawing.Point(12, 12);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(150, 200);
            this.pnlProduct.TabIndex = 3;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(3, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(66, 15);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Products";
            // 
            // pnlTopping
            // 
            this.pnlTopping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopping.Controls.Add(this.chkFruit);
            this.pnlTopping.Controls.Add(this.chkStatement);
            this.pnlTopping.Controls.Add(this.lblTopping);
            this.pnlTopping.Location = new System.Drawing.Point(168, 12);
            this.pnlTopping.Name = "pnlTopping";
            this.pnlTopping.Size = new System.Drawing.Size(150, 200);
            this.pnlTopping.TabIndex = 4;
            // 
            // chkFruit
            // 
            this.chkFruit.AutoSize = true;
            this.chkFruit.Location = new System.Drawing.Point(3, 31);
            this.chkFruit.Name = "chkFruit";
            this.chkFruit.Size = new System.Drawing.Size(56, 19);
            this.chkFruit.TabIndex = 8;
            this.chkFruit.Text = "Fruit";
            this.chkFruit.UseVisualStyleBackColor = true;
            this.chkFruit.CheckedChanged += new System.EventHandler(this.chkFruit_CheckedChanged);
            // 
            // chkStatement
            // 
            this.chkStatement.AutoSize = true;
            this.chkStatement.Location = new System.Drawing.Point(3, 56);
            this.chkStatement.Name = "chkStatement";
            this.chkStatement.Size = new System.Drawing.Size(94, 19);
            this.chkStatement.TabIndex = 7;
            this.chkStatement.Text = "Statement";
            this.chkStatement.UseVisualStyleBackColor = true;
            this.chkStatement.CheckedChanged += new System.EventHandler(this.chkStatement_CheckedChanged);
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Location = new System.Drawing.Point(3, 0);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(59, 15);
            this.lblTopping.TabIndex = 5;
            this.lblTopping.Text = "Topping";
            // 
            // txtStatement
            // 
            this.txtStatement.Enabled = false;
            this.txtStatement.Location = new System.Drawing.Point(78, 66);
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(221, 25);
            this.txtStatement.TabIndex = 6;
            // 
            // pnlOrder
            // 
            this.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder.Controls.Add(this.btnAddOrder);
            this.pnlOrder.Controls.Add(this.lblCurrent);
            this.pnlOrder.Controls.Add(this.lblStatement);
            this.pnlOrder.Controls.Add(this.lblPrice);
            this.pnlOrder.Controls.Add(this.txtStatement);
            this.pnlOrder.Controls.Add(this.txtCurrentPrice);
            this.pnlOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlOrder.Location = new System.Drawing.Point(12, 239);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(306, 136);
            this.pnlOrder.TabIndex = 7;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(6, 97);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(293, 29);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(3, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(53, 15);
            this.lblCurrent.TabIndex = 9;
            this.lblCurrent.Text = "Current";
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Location = new System.Drawing.Point(3, 69);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(72, 15);
            this.lblStatement.TabIndex = 8;
            this.lblStatement.Text = "Statement";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 15);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // pnlImage
            // 
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Controls.Add(this.lblImage);
            this.pnlImage.Location = new System.Drawing.Point(344, 12);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(251, 195);
            this.pnlImage.TabIndex = 10;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(0, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(45, 15);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "Image";
            // 
            // pnlResult
            // 
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.Controls.Add(this.lblResultStatement);
            this.pnlResult.Controls.Add(this.lblTotalPrice);
            this.pnlResult.Controls.Add(this.txtTotalPrice);
            this.pnlResult.Controls.Add(this.txtResult);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Location = new System.Drawing.Point(344, 239);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(251, 136);
            this.pnlResult.TabIndex = 11;
            // 
            // lblResultStatement
            // 
            this.lblResultStatement.AutoSize = true;
            this.lblResultStatement.Location = new System.Drawing.Point(0, 63);
            this.lblResultStatement.Name = "lblResultStatement";
            this.lblResultStatement.Size = new System.Drawing.Size(72, 15);
            this.lblResultStatement.TabIndex = 4;
            this.lblResultStatement.Text = "Statement";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(0, 31);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(72, 15);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "TotalPrice";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(74, 28);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(172, 25);
            this.txtTotalPrice.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(74, 60);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(172, 66);
            this.txtResult.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(3, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 15);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 403);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlTopping);
            this.Controls.Add(this.pnlProduct);
            this.Name = "Form1";
            this.Text = "Bakery";
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlTopping.ResumeLayout(false);
            this.pnlTopping.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlTopping;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.CheckBox chkFruit;
        private System.Windows.Forms.CheckBox chkStatement;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultStatement;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}

