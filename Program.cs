
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LINQ_02.ListGenerator;

namespace LINQ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aggeregation Operators - Immediate Execution

            #region Count() , TryGetNonEnumeratedCount()

            //  var Count = ProductList.Count();
            //  Count = ProductList.Count;
            //  ProductList.TryGetNonEnumeratedCount(out Count);
            //  
            //  IEnumerable<int> Numbers = Enumerable.Range(1, 100); // 1 .. 100
            //  Count = Numbers.Count();
            //
            //  Count = ProductList.Where( p => p.UnitsInStock == 0).Count();
            //  Count = ProductLisat.Count(P => P.UnitsInStock == 0);
            //
            //  Count = ProductList.Where(p => p.UnitsInStock == 0).TryGetNonEnumeratedCount(out Count); //0
            //
            //  Console.WriteLine(Count);
            #endregion

            #region Sum() , Average()

            // var Result = ProductList.Sum(P => P.UnitPrice);
            // 
            // Result =


            #endregion

            #region Max() , Min() [ First 2 Overloads] , MaxBy() , MinBy() [ .NET 6.0 Feature]
            //       var MaxProduct = ProductList.Max();
            //   MaxProduct = ProductList.Max( new ProductComparer() );
            //   MaxProduct = ProductList.OrderByDescending( p => p.UnitPrice).FirstOrDefault();
            //
            //   MaxProduct = ProductList.MaxBy(p => p.UnitPrice);
            //   MaxProduct = ProductList.MaxBy(p => p.UnitsInStock);
            //   MaxProduct = ProductList.MaxBy(p => p.UnitsInStock , new IntComparer());
            //
            //
            //   var MinProduct = ProductList.Min();
            //   MinProduct = ProductList.Min(new ProductComparer() );
            //   MinProduct = ProductList.OrderByDescending(p => p.UnitPrice).FirstOrDefault();
            //   Console.WriteLine(MaxProduct);
            #endregion

            #region Max() , Min() [ Other Overloads] 
            //   var MaxPrice = ProductList.Max(P => P.UnitPrice);
            //
            //   var Result = ProductList.Max(P => P.ProductName);
            //
            //   var MinPrice = ProductList.Max(P => P.UnitPrice);
            //
            //   Result = ProductList.Max(P => P.ProductName);
            //
            //   Console.WriteLine(Result);
            #endregion

            #region Aggregate()
            //
            // string[] Name = ["Bassem", "Amin", "Doaa", "Ahmed"];
            //
            // string FullName = Name.Aggregate((str01 , str02) => $"{str01} , {str02}");
            // FullName = Name.Aggregate("Hello", (str01, str02) => $"{str01} , {str02}");
            // FullName = Name.Aggregate("Hello", (str01, str02) => $"{str01} , {str02}", (TACum) => TACum.Replace(' ' , '$'));
            //
            //
            // Console.WriteLine(FullName);

            #endregion

            #endregion

            #region Conversion ( Casting ) Operators - Immediate Execution

            //    //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //
            //    List<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //
            //    Product[] array = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //
            //    Dictionary<long, Product> dictionary = ProductList.Where(P => P.UnitsInStock == 0)
            //        .ToDictionary(P => P.ProductId);
            //
            //   // Dictionary<long, Product> dictionary = ProductList.Where(P => P.UnitsInStock == 0)
            //   //     .ToDictionary(P => P.ProductId , new CustomEquaultyComparer());
            //
            //    Dictionary<long , string > Dictionary02 = ProductList.Where(P => P.UnitsInStock ==0)
            //        .ToDictionary(P => P.ProductId, P => P.ProductName);
            //
            //    //Dictionary<long, string> Dictionary02 = ProductList.Where(P => P.UnitsInStock == 0)
            //      //.ToDictionary(P => P.ProductId, P => P.ProductName , new CustomEquaultyComparer());
            //
            //    HashSet<Product>  hashSet = ProductList.Where(P => P.UnitsInStock == 0)
            //        .ToHashSet();
            //
            //    //hashSet = ProductList.Where(P => P.UnitsInStock == 0)
            //    //    .ToHashSet(new CustomEquaultyComparer());
            //
            //    var SortedCollection = ProductList.Where( P => P.UnitsInStock ==0).ToImmutableSortedSet();
            //
            //    SortedCollection.Add(new Product() { ProductName = "Hamda" });
            //
            //  
            //    foreach (var item  in SortedCollection)
            //        Console.WriteLine(item);

            #endregion

            #region Generation Operators

          // // The Only Way for calling these Operators => as Static Method throught "Enymerable" Class.
          //
          // var Result = Enumerable.Range(0, 100);
          //
          // foreach(var item in Result)
          //     Console.WriteLine($"{item}\t");
          //
          // Result = Enumerable.Repeat(2, 100);
          //
          // var Result02 = Enumerable.Repeat(new Product() {  Category= "meat"} , 100);
          //
          // var Result = Enumerable.Empty<Product>();
            #endregion
        }
    }
    }
