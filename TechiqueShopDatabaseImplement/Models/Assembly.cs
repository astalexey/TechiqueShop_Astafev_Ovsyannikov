using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TechiqueShopDatabaseImplement.Models
{
    public class Assembly //сборка
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AssemblyName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("AssemblyId")]
        public virtual List<AssemblyComponent> AssemblyComponents { get; set; }
        [ForeignKey("AssemblyId")]
        public virtual List<AssemblyOrder> AssemblyOrders { get; set; }
    }
}
