using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormProduct : Form
    {

        string _ProductName;
        public FormProduct(string ProductName)
        {
            InitializeComponent();

            _ProductName = ProductName;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql = $"Select Production.Product.Name," +
                    $" Production.ProductCategory.Name AS Category," +
                    $" Production.ProductSubcategory.Name AS Subcategory," +
                    $" Production.ProductDescription.Description," +
                    $" Production.Product.ListPrice," +
                    $" Production.Product.Size," +
                    $" Production.Product.ProductLine AS ProLine," +
                    $" Production.Product.Class," +
                    $" Production.Product.Style" +
                $" from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductModel.Name Like '%{_ProductName}%' AND Production.ProductModelProductDescriptionCulture.CultureID = 'en'";
                DetPro product = connection.Query<DetPro>(sql).FirstOrDefault();
                textBoxName.Text = product.Name.ToString();
                textBoxCategory.Text = product.Category;
                textBoxSubcategory.Text = product.Subcategory.ToString();
                textBoxDescription.Text = product.Description.ToString();
                textBoxPrice.Text = product.ListPrice.ToString();
                textBoxSize.Text = product.Size.ToString();
                textBoxPL.Text = product.ProLine.ToString();
                textBoxClass.Text = product.Class.ToString();
                textBoxStyle.Text = product.Style.ToString();        
            }
        }
    }
}
