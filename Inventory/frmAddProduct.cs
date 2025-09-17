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

            foreach (string item in ListOfProductCategory)
            {
                cbCategory.Items.Add(item);
            }
        }

        private int _Quantity;
        private double _SellPrice;

        private void btnAddProduct_Click(object sender, EventArgs e)
        {


        }
    }
}
