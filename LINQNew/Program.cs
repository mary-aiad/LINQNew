using LINQ.Models;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Xml.Linq;
using static LINQ.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Question_07
            //7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.
            //var products = ProductList.Select(x => new { ID = x.ProductID, Name = x.ProductName});

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.ID}. {product.Name}");
            //}

            ///Another Way
            //var products = ProductList.Select((p, i) => $"{i +1 }. {p.ProductName}");
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Question_08
            //8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var result = ProductList.OrderBy(x => x.Category)
            //                        .ThenByDescending(x => x.UnitPrice);

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Name: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            #endregion

            #region Question_09
            //9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

            //var result = ProductList.Where(x => x.Category == "Beverages")
            //                        .OrderByDescending(x => x.UnitsInStock);

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            //}
            #endregion

            #region Question_10
            //10. Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.

            //var orders = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new
            //             {
            //                 CustomerID = c.CustomerID,
            //                 OrderDate = o.OrderDate
            //             };

            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"Customer ID: {order.CustomerID}, Order Date: {order.OrderDate}");
            //}
            #endregion

            #region Question_11
            //11. Show position number alongside ProductName

            //var products = ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question_12
            //12. Sort first by-word length and then by acase -insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //            .OrderBy(x => x.Length)
            //            .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Question_13
            //Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //string[] words = { "Mike", "John", "Bill", "David", "Lisa", "Tim" };
            //var result = words
            //            .Where(x => x.Length > 1 && x[1] == 'i')
            //            .Reverse()
            //            .ToList();

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
        }


    }
}
