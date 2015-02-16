using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DavisonModel;

namespace DavisonService.Respositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private StoreDb db = new StoreDb(); 
        public IEnumerable<Category> GetAll()
        {
            var categories = db.Categories.Where(c => c.Active).ToList();
            return categories;
        }

        public Category GetDetails(int? id)
        {
            var category = db.Categories.Find(id);
            return category;
        }
    }
}