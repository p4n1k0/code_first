﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace code_first.Models
{
    public sealed class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
