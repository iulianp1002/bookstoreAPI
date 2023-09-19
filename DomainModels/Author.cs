﻿namespace Bookstore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int BookId { get; set; }
    }
}