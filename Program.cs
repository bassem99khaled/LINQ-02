

namespace LINQ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators


            // 1. Get first Product out of Stock
            var firstOutOfStockProduct = ListGenerator.ProductList
                    .FirstOrDefault(p => p.UnitsInStock == 0);

              
                // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
                var expensiveProduct = ListGenerator.ProductList
                    .FirstOrDefault(p => p.UnitPrice > 1000);

              
                // 3. Retrieve the second number greater than 5
                int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var secondNumberGreaterThanFive = Arr
                    .Where(n => n > 5)
                    .Skip(1)
                    .FirstOrDefault();

              
            #endregion



        }
    }
    }


