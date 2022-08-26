using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared.Entities
{
    public class OrderItem
    {
        [JsonIgnore]
        public Order? Order { get; set; }
        public Guid OrderId { get; set; }
        [JsonIgnore]
        public Product? Product { get; set; }
        public Guid ProductId { get; set; }
        [JsonIgnore]
        public ProductType? ProductType { get; set; }
        public Guid ProductTypeId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}
