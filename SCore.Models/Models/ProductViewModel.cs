﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCore.Models.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public virtual List<IFormFile> Images { get; set; }
    }
}
