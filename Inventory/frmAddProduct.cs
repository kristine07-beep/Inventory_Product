using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {

        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        public BindingSource showProductList;

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            String[] ListOfProductCategory = new string[]
            {
                "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozne Goods", "Meat", "Personal Care", "Other"
            };

            foreach (string item in ListOfProductCategory) {
                cbCategory.Items.Add(item);
            }
        }

        private int _Quantity;
        private double _SellPrice;

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                showProductList = new BindingSource();

                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (CurrencyFormatException cfe)
            {
                MessageBox.Show(cfe.Message);
            }
            catch (NumberFormatException nfe)
            {
                MessageBox.Show(nfe.Message);
            }
            catch (StringFormatException sfe)
            {
                MessageBox.Show(sfe.Message);
            }
            finally
            {

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public frmAddProduct()
        {
            InitializeComponent();
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("No Default Value for product name");

            return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                throw new NumberFormatException("Invalid number format");

            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Invalid!");

            return Convert.ToDouble(price);
        }

    }
}
