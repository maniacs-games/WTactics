﻿using System;
using System.Collections.Generic;

namespace WTacticsLibrary.Model
{
    public class ResultList<T> where T: Base
    {
        public List<T> Items { get; set; }

        public int TotalItems { get; set; }

        public SearchOptionsBase SearchOptions { get; set; }

        public ResultList()
        {
            Items = new List<T>();
        }

        public ResultList(List<T> items)
        {
            Items = items;
            TotalItems = Items.Count;
        }
    }
}
