using System;

namespace Data.Entities {

    public class Product {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal SupplierPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string SeoAlias { get; set; }
    }
}