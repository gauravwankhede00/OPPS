using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace WebAPI.Model
{
    [Table("Product")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }

        public DateTime CreateDate { get; set; }

        public double Price { get; set; }

        public string ProductDetails { get; set; }
    }


    [Table("Sale")]
    public class Sale
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }

        public string MobileNo { get; set; }
        public DateTime SaleDate { get; set; }

        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public int ProductId { get; set; }

    }


    [Table("Stock")]
    public class Stock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }

    [Table("StockPurchase")]
    public class StockPurchase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public double InvoiceAmout { get; set; }
        public string SupplierName { get; set; }

        public string InvoiceNumber { get; set; }

    }
}
