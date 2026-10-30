using LINQ.Models;
using System.Drawing;
using System.Xml.Linq;
using static LINQ.DataSources.Source;

namespace LINQNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question_01

            //Get all products from the "Seafood" category. Print each
            //product's name and price.

            //var result = ProductList.Where(P => P.Category == "Seafood");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question_02
            //2. Get a list of only the product names from ProductList. Print each name.

            //var result = ProductList.Select(P => P.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_03
            //3. Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var result = ProductList.OrderBy(x => x.UnitPrice);

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            #endregion

            #region Question_04
            //4. Get all products where UnitPrice is between 10 and 30

            //var products = ProductList.Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30);
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            #endregion

            #region Question_05
            //5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //var products = ProductList.Where(p => p.UnitsInStock > 0 && p.Category.Contains("Condiments"));
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Category: {product.Category}, Stock: {product.UnitsInStock}");
            //}
            #endregion

            #region Question_06
            //6. Create a new anonymous type with three properties:Name → the product name, Price → the unit price, StockStatus → a string: "Available" if UnitsInStock > 0,
            // otherwise "Out of Stock", Print the result.

            //var products = ProductList.Select(P => new
            //            {
            //                 Name = P.ProductName,
            //                 Price = P.UnitPrice,
            //                 StockStatus = P.UnitsInStock>0 ? "Available": "Out of Stock"
            //             });

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Name: {product.Name}");
            //    Console.WriteLine($"Price: {product.Price}");
            //    Console.WriteLine($"Stock Status: {product.StockStatus}");
            //    Console.WriteLine("-------------------------");
            //}
            #endregion

        }


    }
}
