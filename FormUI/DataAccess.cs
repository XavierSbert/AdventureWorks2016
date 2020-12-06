using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Product> GetProducts(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                var output = connection.Query<Product>($"Select Production.Product.Name, Production.ProductDescription.Description from Production.Product inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.Product.Name LIKE '%{name}%' AND Production.ProductModelProductDescriptionCulture.CultureID = 'en'").ToList();
                return output;
            }
        }

    }
}
