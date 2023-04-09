﻿namespace FrontToBack.Models
{
    public class Product : BaseEntity
    {
        public string? Header { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
