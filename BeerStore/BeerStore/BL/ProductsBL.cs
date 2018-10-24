using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BeerStore.DAL;

namespace BeerStore.BL
{
    public class ProductsBL
    {
        public DataSet GetProducts()
        {
            ProductsDAL Dal = new ProductsDAL();
            return Dal.getData();
        }
    }
}