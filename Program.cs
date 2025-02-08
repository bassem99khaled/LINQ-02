
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
            // Element Operators Are Vaild Only At Fluent syntax

            #region Element Operators - Immediate Excution

            #region First() , Last() , FirstOrDefault() , LastOrDefualt() - Part 01
            // ProductList = new List<Produdct>();
            //
            // var Result = productList.Frist();
            // Result = ProductList.Last();
            //
            // var Result = ProductList.FirstOrDefault();
            // Result = ProductList.FirstOrDefault(new ProductEqualityComparer() { ProductName = "Bassem" });
            //
            // Result = ProductList.LastOrDefault();
            //
            // Console.WriteLine(Result?.ProductName?? "NA");
            #endregion

            #region First() , Last() , FirstOrDefault() , LastOrDefualt() - Part 02

            // var Result = ProductList.First( P => P.UnitsInStock == 0 );
            // Result = ProductList.Last( P.UnitInStock ==0 ) ;


            // var Result = ProductList.FirstOrDefult( P => P.UnitInStock == 0 );

            #endregion

            #region ElementAt() , ElementAtOrDefault()

            //  var Result = ProductList, ElmentAt(10);
            // Result = productList.ElementAt(new Index(10,true));

            // Result = PrdouctList.ElementAt(^10);

            //var Result = ProductList.ElementAtOrDefault(1000);

 #endregion

            #region Single() , SingleOrDefult - Part 01
            //   var DiscountedProduct = new List<Product>() { ProductList[0] , ProductList[1] };
            //
            //
            // //  var Result = ProductList.Signle();
            //   // if Sequence Contains Just ONly one Element will return signle Element
            //   // else will throw exception ( sequence is empty or contains more than one elment )
            //
            //   var Result = DiscountedProduct.SingleOrDefault();
            //   // if sequence is empety , will return default value for type product
            //   // if seqence Contains just only one element , will return single elment
            //
            //   Result = DiscountedProduct.SingleOrDefault(new Product)
            //
            //
            //

            #endregion

            #region Single() , SingleOrDefult - Part 02
            // Var result = productList.Single(P => P.ProductId == 10);
            // if Sequnce Contains Just only one element Matching Condition , will Return
            // throw Exeption , if Zero or more than one Element is Matching the Conditions

            //   var Result = ProductList.SingleOrDefault(P => P.ProductId == 1000);
            // if Sequnce Contains Just only one element Matching Condition , will Return
            // throw Exeption , if Zero or more than one Element is Matching the Conditions
            // if sequence Contains More than one Element Matching Condition , will throw Exception

            // var Result = ProductList.SingleOrDefault(P => P.ProductId == 1000 , new Product() {  ProductId= 1000 , ProductName = " Bassem"});
            // if Sequnce Contains Just only one element Matching Condition , will Return Specified Defult Value
            // throw Exeption , if Zero or more than one Element is Matching the Conditions, will return Single value
            // if sequence Contains More than one Element Matching Condition , will throw Exception



            #endregion)

            #region firstOrDefault() VS SingleOrDefault()

            // var FirstOrDefault = ProductList.FirstOrDefault(Product => P.ProductId== 10);
            // var SingleOrDefault = ProductList.SingleOrDefault ( p = P.ProductId ==10);
            //
            //
            // Console.WriteLine(SingleOrDefault?.ProductName ?? " NA");

            #endregion

            #region Hybrid Syntax
            // Hybrid Syntax : (Query Expression).Fluent Syntax
            // var Result = from P in ProductList
            //                  where P.UnitsInStock == 0 
            //                  select P).FirstOrDefault();
            //
            #endregion

            #endregion

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

            #region Set Operators - Union Family Operators 

            #region Example 01
            //  var Seq01 = Enumerable.Range(0, 100);
            //  var Seq02 = Enumerable.Range(50, 100);
            //
            //  var Result = Seq01.Union(Seq02); // Mergin with Removing Duplicates [0 - 99 - 149 ]
            //
            //  Result = Seq01.Concat(Seq02); // Mergiing without Removing Dulicates
            //
            //  Result = Result.Distinct(); // Remove Dublicates [ Filtration Operators ]
            //
            //  Result = Seq01.Intersect(Seq02); // [ 50 .. 99]
            //
            //  Result = Seq01.Except(Seq02); // [ 0 .. 49]
            //
            //  foreach (var item in Result) 
            //      Console.WriteLine(item);
            //
            #endregion

            #region Example 02

            //  var Seq01 = new List<Product>
            //  { };
            //  var Seq02 = new List<Product>
            //  { };

            /// var Result = Seq01.Union(Seq02); // merging with Removing Duplication
            ///
            /// Result = Seq01.Union(Seq02, new ProductEqualityComparer());
            ///
            /// Result = Seq01.UnionBy(Seq02, P => P.ProductId);
            /// Result = Seq01.UnionBy(Seq02, P => P.Category , new CategoryEqulityComparer());

            ///  var Result = Seq01.Intersect(Seq02);
            ///  var Result = Seq01.Intersect(Seq02, new ProductEqualityComparer());
            ///
            ///  Result = Seq01.IntersectBy(Seq02.Select(P2 = P2.UnitPrice), P => P.UnitPrice);
            ///

            ///   var Result =Seq01.Except(Seq02);
            ///   Result = Seq01.Except(Seq02, new ProductEqualityComparer());
            ///   Result = Seq01.Except(Seq02.Select(P2 => P2.UnitPrice) , P =>P.UnitPrice)  ;
            ///   

            /// var Result = Seq01.Distinct();
            /// Result = Seq01.Distinct(new ProductEqualityComparer());
            /// Result = Seq01.Distinct(P => P.Category , new ProductEqualityComparer);

            // foreach (var item in Result)
            //     Console.WriteLine(item);

            #endregion

            #endregion

            #region Quantifier Operators - Return Boolean Value

            //  var Product = new Product();
            //      {
            //      productId =1
            //      productName = ""
            //      Cagegory = ""
            //      unitPrice = 8000
            //  };


            //  Console.WriteLine(
            //ProductList.Any() // Return True , if Sequence Contains at Least One Element
            // ProductList.Any(P => P.UnitsInStock ==0 ) // Retrun true . if Sequence Contains at least one matching element
            // ProductList,All(P => P.UnitsInStock > 0) // return ture , if All Elements of sequence are MAtching the condition
            //ProductList.Contains(Product)
            //productlist,Contians(Product , new ProductEqualityComparer())
            //                  );
            #endregion

            #region Transformation Operators | ZIP

            //   List<string> Words = new List<string>() {  " Ten" , " TWenty" , " Thrity" ,"Fourty"};
            //
            //   int[] Numbers = [10, 20, 30, 40, 50, 60, 70];
            //   
            //   var Result = Numbers.Zip(Words);
            //   var Result02 = Numbers.Zip(Words, (number ,word) => $"{number} == {word}");
            //   var Result03 = Numbers.Zip(Words, [1, 2, 3]); // C# 10.0 Feature
            //
            //   foreach (var item in Result03)
            //       Console.WriteLine(item);
            #endregion

        }
    }
    }
