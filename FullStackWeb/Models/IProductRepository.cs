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
    }
}
