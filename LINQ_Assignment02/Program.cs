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

            #region Q10 : Check All Products of "Seafood" In Stock
            //var SeafoodProductsInStock = ProductList.Where(P=>P.Category == "Seafood")
            //    .All(P=>P.UnitsInStock>0);

            //Console.WriteLine($"All Seafood Products In Stock: {SeafoodProductsInStock}");
            #endregion

            #region Q11 : Check IDs contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //var DoesIdsContains9 = ids.Contains(9);

            //Console.Write($"Does IDs contains 9? ");
            //if (DoesIdsContains9)
            //{
            //    Console.Write("Yes");
            //}
            //else Console.Write("No");
            #endregion

            #region Q12 : Count products in each category

            //var ProductsWithCategory = ProductList.GroupBy(P => P.Category)
            //    .Select(P => new { Category = P.Key, ProductCount = P.Count() });

            //foreach (var product in ProductsWithCategory)
            //{
            //    Console.WriteLine($"{product.Category}: {product.ProductCount}");
            //}

            ////---------------------------------------------------------------------------------------
            ////var ProductsWithCategory = ProductList.GroupBy(P => P.Category)  //>>>> Counts Groubs
            ////    .Count(); 
            ////Console.WriteLine($"Total Categories: {ProductsWithCategory}");

            #endregion

            #region Q13 : Show products name with category

            //var ProductsWithCategory = ProductList.GroupBy(P => P.Category)
            //    .Select(P => new { Category = P.Key, ProductNames = P.Select(p => p.ProductName) });
            //foreach (var product in ProductsWithCategory)
            //{
            //    Console.WriteLine($"{product.Category}:{string.Join(", ", product.ProductNames)}");
            //}

            #endregion

            #region Q14: Categorys with more than 3 products

            //var res = ProductList.GroupBy(P => P.Category)
            //    .Where(P => P.Count() > 3)
            //    .Select(P => new { Category = P.Key });

            //foreach(var category in res)
            //{
            //    Console.WriteLine(category.Category);
            //}
            #endregion

            #region Q15 : Count customers in each country and total orders for each country

            //var OrdersInCountries = from c in CustomerList
            //                        from o in c.Orders
            //                        group c by c.Country into CountryGroup
            //                        select new
            //                        {

            //                            Country = CountryGroup.Key,
            //                            CustomerCount = CountryGroup.Count(),
            //                            TotalOrderCount = CountryGroup.SelectMany(c => c.Orders).Sum(o => o.OrderID)

            //                        };
            //foreach (var country in OrdersInCountries)
            //{
            //    Console.WriteLine($"Country: {country.Country}, Customer Count: {country.CustomerCount}, Total Order Count: {country.TotalOrderCount}");
            //}



            #endregion

            #region Q16 : Total Units in Stock
            //var TotalUnitsInStock = ProductList.Sum(P => P.UnitsInStock);
            //Console.WriteLine($"Total Units in Stock: {TotalUnitsInStock}");
            #endregion

            #region Q17 : Cheapiest and Most Expensive Product

            //var MostExpensive = ProductList.Max(P => P.UnitPrice);
            //var Cheapest = ProductList.Min(P => P.UnitPrice);
            //Console.WriteLine($"Most Expensive Product Price: {MostExpensive}");
            //Console.WriteLine($"Cheapest Product Price: {Cheapest}");

            #endregion

            #region Q18 : Distinct list of all product categories

            //var DistinctCategories = ProductList.Select(P => P.Category).Distinct();
            //foreach (var category in DistinctCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region Q19 : in SetA but not in SetB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var inSetANotInSetB = setA.Except(setB);
            //foreach (var item in inSetANotInSetB)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q20 : Countries in list1 but not in list2 (case-insensitive)
            //string[] list1 = { "Germany", "France", "UK", "Spain" }; 
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var countriesInList1ButNotInList2 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var country in countriesInList1ButNotInList2)
            //{
            //    Console.WriteLine(country);
            //}
            #endregion

        }
    }
}
