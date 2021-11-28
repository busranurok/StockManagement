using System;
using StockManagement.Entity.Abstract;

namespace StockManagement.Entity.Dtos
{
    public class InsertCategoryDto : IDto
    {
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
