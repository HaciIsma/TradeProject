﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeProject.Model
{
    public class StorageProduct
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int StorageCount { get; set; }
        public int ComingStorage { get; set; }
        public int LeaveStorage { get; set; }
    }
}
