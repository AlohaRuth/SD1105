﻿using System;
using System.Collections.Generic;

namespace Sakila2.Models
{
    public partial class FilmCategory
    {
        public int FilmId { get; set; }
        public byte CategoryId { get; set; }
        public DateTime LastUpdate { get; set; }

        public Category Category { get; set; }
        public Film Film { get; set; }
    }
}
