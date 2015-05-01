using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICAWindowsApp.Model
{
    class ProductDTO
    {

        public virtual int Id { get; set; }
        public virtual string EAN { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int BrandId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual double Price { get; set; }
        public virtual int StockLevel { get; set; }
        public virtual bool Active { get; set; }

        public virtual CategoryDTO Category { get; set; }
        public virtual CategoryDTO Brand { get; set; }



    }
}
