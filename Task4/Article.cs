using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Article
    {
        private string productTitle;
        private string storeTitle;
        private decimal productPrice;

        public decimal ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }
        public string StoreTitle
        {
            get => storeTitle;
            set => storeTitle = value;
        }
        public string ProductTitle
        {
            get => productTitle;
            set => productTitle = value;
        }

        public Article(string prodTitle, string storeTitle,decimal prodPrice)
        {
            this.productTitle = prodTitle;
            this.storeTitle = storeTitle;
            this.productPrice = prodPrice;
        }
    }
}
