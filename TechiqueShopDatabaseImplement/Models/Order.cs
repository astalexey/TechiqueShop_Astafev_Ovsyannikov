using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TechiqueShopDatabaseImplement.Models
{
    public class Order // заказ
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OrderName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("OrderId")]
        public virtual List<SupplyOrder> SupplyOrders { get; set; }
        [ForeignKey("OrderId")]
        public virtual List<AssemblyOrder> AssemblyOrders { get; set; }
    }
}
