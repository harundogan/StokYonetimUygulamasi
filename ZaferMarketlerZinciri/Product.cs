using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ZaferMarketlerZinciri
{
    public class Product
    {
        public int ID { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Tipi")]
        public string Type { get; set; }
        [DisplayName("Birim Fiyat")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Stok Adedi")]
        public int StockAmount { get; set; }
    }
}
