using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TechiqueShopDatabaseImplement.Models
{
    public class Component // комплектующие
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ComponentName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("ComponentId")]
        public virtual List<AssemblyComponent> AssemblyComponents { get; set; }
        [ForeignKey("ComponentId")]
        public virtual List<DeliveryComponent> DeliveryComponents { get; set; }


    }
}
