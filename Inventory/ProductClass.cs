using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class ProductClass
    {

        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate,
        double Price, int Quantity, string Description)
        {
            this._Quantity = Quantity;
            this._SellingPrice = Price;
            this._ProductName = ProductName;
            this._Category = Category;
            this._ManufacturingDate = MfgDate;
            this._ExpirationDate = ExpDate;
            this._Description = Description;
        }
        

    }
    }
