using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared.Entities
{
    public class CartItem
    {
        [JsonIgnore]
        public User? User { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public Product? Product { get; set; }
        public Guid ProductId { get; set; }
        [JsonIgnore]
        public ProductType? ProductType { get; set; }
        public Guid ProductTypeId { get; set; }
        public int Quantity { get; set; } = 1;

    }
}
