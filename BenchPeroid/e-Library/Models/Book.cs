using System;
using System.Collections.Generic;

namespace e_Library.Models
{
    public partial class Book
    {
        public int Bid { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int Price { get; set; }
        public string? Publication { get; set; }
    }
}
