﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DavisonService.Respositories;
using System.Web.Http.Description;
using ViewModels;
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
            var filteredProducts = new List<ProdVM>().AsEnumerable();

            filteredProducts = FindProducts().Distinct(new ProductComparer());

            return filteredProducts;
        }

        [Route("api/GetProductDetails/{ean}")]
        [ResponseType(typeof(ProdVM))]
        public IEnumerable<ProdVM> GetProductDetails(string ean)
        {
            return FindProducts().Where(p => p.EAN == ean)
                .Select(prod => new ProdVM
                {
                    Id = prod.Id,
                    EAN = prod.EAN,
                    CategoryId = prod.CategoryId,
                    BrandId = prod.BrandId,
                    Name = prod.Name,
                    Description = prod.Description,
                    Price = prod.Price,
                    StockLevel = prod.StockLevel,
                    Active = prod.Active,
                    Category = prod.Category,
                    Brand = prod.Brand,
                    VendorID = prod.VendorID
                }).OrderBy(p => p.Price);
        }

        public IEnumerable<ProdVM> FindProducts() 
        {
            var allProducts = new List<ProdVM>().AsEnumerable();

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
                    Category = p.Category == null ? "" : p.Category.Name,
                    Brand = p.Brand == null ? "" : p.Brand.Name,
                    VendorID = 1
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
                    Category = p.Category == null ? "" : p.Category.Name,
                    Brand = p.Brand == null ? "" : p.Brand.Name,
                    VendorID = 2
                }).AsEnumerable();

            var bazzasBazzarProducts = bazzasBazzarRepository.GetAllProducts();

            allProducts = davisonProducts.Concat(underCuttersProducts);

            allProducts = allProducts.Concat(bazzasBazzarProducts);

            return allProducts;
        }
    }
}
