﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DavisonService.Respositories;
using System.Web.Http.Description;
using DavisonService.ViewModels;
using DavisonService.CompareClasses;

namespace DavisonService.Controllers
{
    public class ProductController : ApiController
    {
        private DavisonRepository davisonRepository = new DavisonRepository();
        private UnderCuttersRepository underCuttersRepository = new UnderCuttersRepository();
        private BazzasBazzarRepository bazzasBazzarRepository = new BazzasBazzarRepository();

        [ResponseType(typeof(ProdVM))]
        public IEnumerable<ProdVM> GetProducts()
        {
            var allProducts = new List<ProdVM>().AsEnumerable();
            var filteredProducts = new List<ProdVM>().AsEnumerable();

            var davisonProducts = davisonRepository.GetAllProducts()
                .Select(p => new ProdVM
                {
                    Id = p.Id,
                    EAN = p.Ean,
                    CategoryId = p.CategoryId,
                    BrandId = p.BrandId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    StockLevel = p.StockLevel,
                    Active = p.Active,
                    Category = p.Category,
                    Brand = p.Brand
                }).AsEnumerable();

            var underCuttersProducts = underCuttersRepository.GetAllProducts()
                .Select(p => new ProdVM
                {
                    Id = p.Id,
                    EAN = p.Ean,
                    CategoryId = p.CategoryId,
                    BrandId = p.BrandId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    StockLevel = p.StockLevel,
                    Active = p.Active,
                    Category = p.Category,
                    Brand = p.Brand
                }).AsEnumerable();

            var bazzasBazzarProducts = bazzasBazzarRepository.GetAllProducts();

            allProducts = davisonProducts.Concat(underCuttersProducts);

            allProducts = allProducts.Concat(bazzasBazzarProducts);

            filteredProducts = allProducts.Distinct(new ProductComparer());

            return filteredProducts;
        }

        [Route("api/GetProductDetails/{ean}")]
        [ResponseType(typeof(ProdVM))]
        public ProdVM GetProductDetails(string ean)
        {
            int hey = Convert.ToInt32(ean);
            var prod = underCuttersRepository.GetProductDetails(hey);
            return (new ProdVM
                {
                    Id = prod.Id,
                    EAN = prod.Ean,
                    CategoryId = prod.CategoryId,
                    BrandId = prod.BrandId,
                    Name = prod.Name,
                    Description = prod.Description,
                    Price = prod.Price,
                    StockLevel = prod.StockLevel,
                    Active = prod.Active,
                    Category = prod.Category,
                    Brand = prod.Brand
                });
        }
    }
}
