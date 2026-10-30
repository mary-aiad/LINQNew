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
        }


    }
}
