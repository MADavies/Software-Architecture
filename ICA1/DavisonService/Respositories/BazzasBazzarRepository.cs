using System.Collections.Generic;
using System.Linq;
using DavisonService.BazzasBazzar;
using DavisonService.ViewModels;
using DavisonService.Models;
using System;

namespace DavisonService.Respositories
{
    public class BazzasBazzarRepository
    {
        private StoreClient client = new StoreClient();

        public IEnumerable<ProdVM> GetAllFiltered(int? id, string catName)
        {
            return client.GetFilteredProducts(id, catName, null, null)
                .Select(p => new ProdVM
                {
                    Id = p.Id,
                    EAN = p.Ean,
                    CategoryId = p.CategoryId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.PriceForOne
                }).AsEnumerable();
        }

        public IEnumerable<ProdVM> GetAllProducts()
        {
            return client.GetFilteredProducts(null, null, null, null)
                .Select(p => new ProdVM
                {
                    Id = p.Id,
                    EAN = p.Ean,
                    CategoryId = p.CategoryId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.PriceForOne
                }).AsEnumerable();
        }

        public Product GetProductDetails(int id)
        {
            return client.GetProductById(id);
        }

        public IEnumerable<CatVM> GetAllCat()
        {
            return client.GetAllCategories()
                .Select(c => new CatVM
                {
                    Id = c.Id,
                    Name = c.Name,
                }).AsEnumerable();
        }

        public Category GetCatDetails(int id)
        {
            return client.GetCategoryById(id);
        }

         public DavisonService.Models.Order PostOrder(OrderRequest or)
         {
             DavisonService.Models.Order o = new DavisonService.Models.Order();
             BazzasBazzar.Order bo = client.CreateOrderAsync(or.AccountName, or.CardNumber, or.ProductID, or.Quantity).Result;
             o.CardNumber = bo.CardNumber;
             o.AccountName = bo.AccountName;
             o.ProductID = bo.ProductId;
             o.ProductEan = bo.ProductEan;
             o.ProductName = bo.ProductName;
             o.Quantity = or.Quantity;
             o.TotalPrice = or.Quantity * bo.TotalPrice;
             o.When = DateTime.Now;

             return o;
         }
    }
}