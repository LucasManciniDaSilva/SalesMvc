using System.Collections.Generic;
using System;
using System.Linq;
namespace SalesWebMvc.Models

{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Sellers> SellersProperty { get; set; } = new List<Sellers>();


        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Sellers seller)
        {
            SellersProperty.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return SellersProperty.Sum(seller => seller.TotalSales(initial, final));

        }

    }
}
