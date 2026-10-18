using System;
using System.Collections.Generic;
using LINQ.Models;
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

            #region Q3 : List orders in 1997 or later

            //var OrdersIn1997OrLater = from c in CustomerList
            //                          from o in c.Orders
            //                          where o.OrderDate.Year >= 1997
            //                          select new { c.CustomerID, o.OrderDate};

            //foreach(var order in OrdersIn1997OrLater)
            //{
            //    Console.WriteLine($"CustomerID= {order.CustomerID}, OrderDate= {order.OrderDate:d}");
            //}

            #endregion

            #region Q4 : Show Position along with productName

            //var ProductsWithPosition = ProductList.Select((P, i)=> new { P.ProductName, Position = i + 1 });

            //foreach (var product in ProductsWithPosition)
            //{
            //    Console.WriteLine($"{product.Position}. {product.ProductName}");
            //}

            #endregion

            #region Q5 : Sort array of strings by length then by case-insensitive sort of the words

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var SortedArr = Arr.OrderBy(s => s.Length)
            //                   .ThenBy(s => s, StringComparer.OrdinalIgnoreCase);

            //foreach(var str in SortedArr)
            //{
            //    Console.WriteLine(str);
            //}

            #endregion

            #region Q6 : Reverse digits, 'i' second letter

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var reversedArr = Arr.Where(s => s[1] == 'i')
            //    .Reverse()
            //    .ToList();

            //foreach(var digit in reversedArr)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region Q7 : Get Top 3 expensive products 

            //var TopPruducts = ProductList.OrderByDescending(P => P.UnitPrice)
            //    .Take(3)
            //    .Select((P, I) => new { P.ProductName, P.UnitPrice, Position = I + 1 });

            //foreach (var product in TopPruducts)
            //{
            //    Console.WriteLine($"{product.Position}. {product.ProductName} - {product.UnitPrice}");
            //}

            #endregion

            #region Q8 : Show page 2 of Products

            //var Page2Products = ProductList.Skip(5)
            //    .Take(5)
            //    .Select((P, I) => new { P.ProductName, P.UnitPrice, position = I + 1 });

            //foreach (var product in Page2Products)
            //{
            //    Console.WriteLine($"{product.position}. {product.ProductName} - {product.UnitPrice}");
            //}

            #endregion

            #region Q9 : Show products as long as price = 25
            //var ProductsAt25 = ProductList.OrderBy(P => P.UnitPrice)
            //    .TakeWhile(P => P.UnitPrice < 25)
            //    .Select(P => P);    

            //foreach(var product in ProductsAt25)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
        }
    } 
}
