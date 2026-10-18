using System;
using System.Collections.Generic;
using static LINQ.DataSources.Source;

namespace LINQ.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 : Products sorted by category $ unit price

            //var SortedProducts = ProductList.OrderBy(P => P.Category)
            //                                .ThenByDescending(P => P.UnitPrice)
            //                                .Select(P => new { P.ProductName, P.Category, P.UnitPrice});

            //foreach(var product in SortedProducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q2 : Get products from "Beverages" category sorted by UnitInStuck

            //var BeveragesProducts = ProductList.Where(P => P.Category == "Beverages")
            //                                   .OrderByDescending(P => P.UnitsInStock)
            //                                   .Select(P => P);

            //foreach( var product in BeveragesProducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion



        }
    }
}
