﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Repository.Model
{
    public partial class VProductAndDescription
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductModel { get; set; }
        public string CultureId { get; set; }
        public string Description { get; set; }
    }
}