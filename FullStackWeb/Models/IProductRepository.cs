using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullStackWeb.Models
{
    public interface IProductRepository
    {
       public IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
        public Product AssignCategory();
        public IEnumerable<Category> GetCategories();
        public void InsertProduct(Product productToInsert);
    }
}
