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
    public partial class Form1 : Form
    {
        DataAccess db = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql = $"Select Production.ProductCategory.Name from Production.ProductCategory";
                List<string> categories = new List<string>();
                categories = connection.Query<string>(sql).ToList();
                foreach (string category in categories)
                {
                   comboBoxCategoria.Items.Add(category);
                }
            }
            comboBoxLanguage.SelectedIndex = 0;

        }

        private void SubCatLoad(string cate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql = $"Select Production.ProductSubcategory.Name from Production.ProductSubcategory inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID where Production.ProductCategory.Name like '{ comboBoxCategoria.Text }'";
                List<string> subcategories = new List<string>();
                subcategories = connection.Query<string>(sql).ToList();
                foreach (string category in subcategories)
                {
                    comboBoxSubCategory.Items.Add(category);
                }
            }
        }

        private void SizeLoad(string cate, string subcate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql =
                "Select DISTINCT Production.Product.Size from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductSubcategory.Name LIKE '{comboBoxSubCategory.Text}' AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text}'";
                List<string> size = new List<string>();
                size = connection.Query<string>(sql).ToList();
                if (size.Count() > 1)
                {
                    foreach (string category in size)
                    {
                        comboBoxSize.Items.Add(category);
                    }
                }


            }
        }

        private void ProductLineLoad(string cate, string subcate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql =
                "Select DISTINCT Production.Product.ProductLine from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductSubcategory.Name LIKE '{comboBoxSubCategory.Text}' AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text}'";
                List<string> pl = new List<string>();
                pl = connection.Query<string>(sql).ToList();
                if (pl.Count() > 1)
                {
                    foreach (string category in pl)
                    {
                        comboBoxProductLine.Items.Add(category);
                    }
                }

            }
        }

        private void ClassLoad(string cate, string subcate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql =
                "Select DISTINCT Production.Product.Class from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductSubcategory.Name LIKE '{comboBoxSubCategory.Text}' AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text}' AND Production.Product.Class IS NOT NULL";
                List<string> pl = new List<string>();
                pl = connection.Query<string>(sql).ToList();
                if (pl.Count() > 1)
                {
                    foreach (string category in pl)
                    {
                        comboBoxClass.Items.Add(category);
                    }
                }

            }
        }

        private void StyleLoad(string cate, string subcate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql =
                "Select DISTINCT Production.Product.Style from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductSubcategory.Name LIKE '{comboBoxSubCategory.Text}' AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text}'";
                List<string> pl = new List<string>();
                pl = connection.Query<string>(sql).ToList();
                if (pl.Count() > 1)
                {
                    foreach (string category in pl)
                    {
                        comboBoxStyle.Items.Add(category);
                    }
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql =
                "Select DISTINCT Production.ProductModel.Name from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductSubcategory.Name LIKE '{comboBoxSubCategory.Text}' AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text}' AND Production.ProductModel.Name like '%{textBoxProduct.Text}%'";
                List<string> pl = new List<string>();
                pl = connection.Query<string>(sql).ToList();
                if (pl.Count() > 1)
                {
                    foreach (string category in pl)
                    {
                        listViewProduct.Items.Add(category);
                    }
                }

            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewProduct.Items.Clear();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
               {
                   string sql = "Select DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text}'";

                List<Product> categories = new List<Product>();
                categories = connection.Query<Product>(sql).ToList();
                foreach (Product category in categories)
                {
                    listViewProduct.Items.Add(category.ToString());
                }
                comboBoxStyle.Text = "";
                comboBoxStyle.Items.Clear();
                comboBoxClass.Text = "";
                comboBoxClass.Items.Clear();
                comboBoxProductLine.Text = "";
                comboBoxProductLine.Items.Clear();
                comboBoxSize.Text = "";
                comboBoxSize.Items.Clear();
                comboBoxSubCategory.Text = "";
                comboBoxSubCategory.Items.Clear();
                SubCatLoad(comboBoxCategoria.Text);
            }


        
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewProduct.Items.Clear();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql = "Select DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description from Production.Product" +
                " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
                " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
                " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
                " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
                " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
                $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductSubcategory.Name LIKE '{comboBoxSubCategory.Text}' AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text} '";

                List<Product> subcategories = new List<Product>();
                subcategories = connection.Query<Product>(sql).ToList();
                foreach (Product category in subcategories)
                {
                    listViewProduct.Items.Add(category.ToString());
                }

                comboBoxStyle.Text = "";
                comboBoxStyle.Items.Clear();
                comboBoxClass.Text = "";
                comboBoxClass.Items.Clear();
                comboBoxProductLine.Text = "";
                comboBoxProductLine.Items.Clear();
                comboBoxSize.Text = "";
                comboBoxSize.Items.Clear();
                comboBoxSize.Text = "";
                comboBoxProductLine.Items.Clear();
                numericUpDownMin.Value = 0;
                numericUpDownMax.Value = 9999;
                StyleLoad(comboBoxCategoria.Text, comboBoxSubCategory.Text);
                ClassLoad(comboBoxCategoria.Text, comboBoxSubCategory.Text);
                ProductLineLoad(comboBoxCategoria.Text, comboBoxSubCategory.Text);
                SizeLoad(comboBoxCategoria.Text, comboBoxSubCategory.Text);
            }
        }

        // ------------------- FILTERS -----------------

        private void Filters()
        {
            listViewProduct.Items.Clear();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProductModel")))
            {
                string sql =
            "Select DISTINCT Production.Product.Name, Production.ProductDescription.Description from Production.Product" +
            " inner join Production.ProductModel on Production.ProductModel.ProductModelID = Production.Product.ProductModelID" +
            " inner join Production.ProductModelProductDescriptionCulture on Production.ProductModelProductDescriptionCulture.ProductModelID = Production.ProductModel.ProductModelID" +
            " inner join Production.ProductDescription on Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID" +
            " inner join Production.ProductSubcategory on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID" +
            " inner join Production.ProductCategory on Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID" +
            $" WHERE Production.ProductCategory.Name LIKE '{comboBoxCategoria.Text}' AND Production.ProductSubcategory.Name LIKE '{comboBoxSubCategory.Text}'" +
            $" AND ( Production.Product.Size is null or Production.Product.Size like '%{comboBoxSize.Text}%')" +
            $" AND ( Production.Product.ProductLine is null or Production.Product.ProductLine like '%{comboBoxProductLine.Text}%' )" +
            $" AND ( Production.Product.Class is null or Production.Product.Class like '%{comboBoxClass.Text}%')" +
            $" AND ( Production.Product.Style is null or Production.Product.Style like '%{comboBoxStyle.Text}%')" +
            $" and Production.Product.ListPrice BETWEEN {numericUpDownMin.Value} and {numericUpDownMax.Value} " +
            $" AND Production.ProductModelProductDescriptionCulture.CultureID = '{comboBoxLanguage.Text}'";

            List<Product> size = new List<Product>();
            size = connection.Query<Product>(sql).ToList();
                if (size.Count == 0)
                {
                    MessageBox.Show("There is no product with these filters. TRY ANOTHER COMBINATION", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    foreach (Product category in size)
                    {
                        listViewProduct.Items.Add(category.ToString());
                    }
                }
        }
    }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void comboBoxProductLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            Filters();
        }

        private void numericUpDownMax_ValueChanged(object sender, EventArgs e)
        {
            Filters();
        }
    }
}
    