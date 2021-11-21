﻿using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Concrete
{
    public class ECommerceSite : IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
