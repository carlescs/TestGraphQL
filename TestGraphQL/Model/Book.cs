﻿using System.ComponentModel.DataAnnotations;

namespace TestGraphQL.Model
{
    public class Book
    {
        [MaxLength(256), Required]
        public string Title { get; set; } = null!;
        public Author Author { get; set; } = null!;
    }
}
