﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.DTO
{
    public class CreateBookDTO
    {
        public string Title { get; set; }
        public decimal Price { get; set; } 
        public string Author { get; set; } 
        public string Description { get; set; }
        public string ISBN { get; set; }

    }
}
