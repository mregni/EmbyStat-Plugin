﻿using System.Collections.Generic;

namespace Plugin.Models.DataGrid
{
    public class Page<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalCount { get; set; }
    }
}
