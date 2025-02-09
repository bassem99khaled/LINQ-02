

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

            #region LINQ - Aggregate Operators


                
                // 1. Count of odd numbers in the array
            
            var oddNumbersCount = Arr.Count(n => n % 2 != 0);
                Console.WriteLine("\nNumber of odd numbers: " + oddNumbersCount);



                // 2. List of customers and how many orders each has
                var customerOrders = ListGenerator.CustomerList
                    .Select(c => new { c.CustomerName, OrderCount = c.Orders?.Length ?? 0 });

               
                foreach (var customer in customerOrders)
                {
                    Console.WriteLine($"{customer.CustomerName}: {customer.OrderCount} orders");
                }


                // 3. List of categories and how many products each has
                var categoryProducts = ListGenerator.ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, ProductCount = g.Count() });

                foreach (var category in categoryProducts)
                {
                    Console.WriteLine($"{category.Category}: {category.ProductCount} products");
                }

                // 4. Total of numbers in an array
                var totalSum = Arr.Sum();
                Console.WriteLine("\nTotal of numbers: " + totalSum);



                // 5-8. Dictionary file operations

                string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");

                var totalCharacters = dictionaryWords.Sum(w => w.Length);
                var shortestWordLength = dictionaryWords.Min(w => w.Length);
                var longestWordLength = dictionaryWords.Max(w => w.Length);
                var averageWordLength = dictionaryWords.Average(w => w.Length);

              

                // 9. Total units in stock for each product category
                var totalUnitsInStock = ListGenerator.ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });

               
                foreach (var category in totalUnitsInStock)
                {
                    Console.WriteLine($"{category.Category}: {category.TotalUnits} units");
                }



                // 10. Cheapest price among each category's products
                var cheapestPricePerCategory = ListGenerator.ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });

              
                foreach (var category in cheapestPricePerCategory)
                {
                    Console.WriteLine($"{category.Category}: {category.CheapestPrice:C}");
                }


                // 11. Products with the cheapest price in each category (using let)
                var cheapestProductsPerCategory = ListGenerator.ProductList
                    .GroupBy(p => p.Category)
                    .SelectMany(g =>
                    {
                        var minPrice = g.Min(p => p.UnitPrice);
                        return g.Where(p => p.UnitPrice == minPrice)
                                .Select(p => new { p.Category, Product = p.ProductName, p.UnitPrice });
                    });

                foreach (var product in cheapestProductsPerCategory)
                {
                    Console.WriteLine($"{product.Category}: {product.Product} at {product.UnitPrice:C}");
                }


                // 12. Most expensive price among each category's products

                var mostExpensivePricePerCategory = ListGenerator.ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) });


                foreach (var category in mostExpensivePricePerCategory)
                {
                    Console.WriteLine($"{category.Category}: {category.MostExpensivePrice:C}");
                }


                // 13. Products with the most expensive price in each category

                var mostExpensiveProductsPerCategory = ListGenerator.ProductList
                    .GroupBy(p => p.Category)
                    .SelectMany(g =>
                    {
                        var maxPrice = g.Max(p => p.UnitPrice);
                        return g.Where(p => p.UnitPrice == maxPrice)
                                .Select(p => new { p.Category, Product = p.ProductName, p.UnitPrice });
                    });

               
                foreach (var product in mostExpensiveProductsPerCategory)
                {
                    Console.WriteLine($"{product.Category}: {product.Product} at {product.UnitPrice:C}");
                }


                // 14. Average price of each category's products

                var averagePricePerCategory = ListGenerator.ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });

                Console.WriteLine("\nAverage price per category:");
                foreach (var category in averagePricePerCategory)
                {
                    Console.WriteLine($"{category.Category}: {category.AveragePrice:C}");
                }

            #endregion

            #region Set Operators


                 // 1. Unique Category names from Product List
           
            var uniqueCategories = ListGenerator.ProductList
                    .Select(p => p.Category)
                    .Distinct();

               
                foreach (var category in uniqueCategories)
                {
                    Console.WriteLine(category);
                }




                // 2. Unique first letter from both product and customer names
               
            var uniqueFirstLetters = ListGenerator.ProductList.Select(p => p.ProductName[0])
                    .Union(ListGenerator.CustomerList.Select(c => c.CustomerName[0]))
                    .Distinct();


                foreach (var letter in uniqueFirstLetters)
                {
                    Console.WriteLine(letter);
                }



                // 3. Common first letter from both product and customer names
              
            var commonFirstLetters = ListGenerator.ProductList.Select(p => p.ProductName[0])
                    .Intersect(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));


                foreach (var letter in commonFirstLetters)
                {
                    Console.WriteLine(letter);
                }



                // 4. First letters of product names not in customer names
              
            var productFirstLettersNotInCustomers = ListGenerator.ProductList.Select(p => p.ProductName[0])
                    .Except(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));


                foreach (var letter in productFirstLettersNotInCustomers)
                {
                    Console.WriteLine(letter);
                }


              
                // 5. Last three characters in each name of all customers and products
               
            var lastThreeChars = ListGenerator.CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName)
                    .Concat(ListGenerator.ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName));


                foreach (var chars in lastThreeChars)
                {
                    Console.WriteLine(chars);
                }


            #endregion

            #region Partitioning Operators


            // 1. Get the first 3 orders from customers in Washington
         
            var firstThreeOrdersInWashington = ListGenerator.CustomerList
                    .Where(c => c.Region == "WA")
                    .SelectMany(c => c.Orders)
                    .Take(3);

                foreach (var order in firstThreeOrdersInWashington)
                {
                    Console.WriteLine(order);
                }


                // 2. Get all but the first 2 orders from customers in Washington
                
            var allButFirstTwoOrdersInWashington = ListGenerator.CustomerList
                    .Where(c => c.Region == "WA")
                    .SelectMany(c => c.Orders)
                    .Skip(2);

                foreach (var order in allButFirstTwoOrdersInWashington)
                {
                    Console.WriteLine(order);
                }



                // 3. Return elements starting from the beginning until a number is less than its position
               
            var numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var numbersUntilLessThanPosition = numbers
                    .TakeWhile((n, index) => n >= index);

                foreach (var num in numbersUntilLessThanPosition)
                {
                    Console.WriteLine(num);
                }

                
                // 4. Get elements starting from the first element divisible by 3
              
            var numbersFromFirstDivByThree = numbers
                    .SkipWhile(n => n % 3 != 0);

                foreach (var num in numbersFromFirstDivByThree)
                {
                    Console.WriteLine(num);
                }

              
                // 5. Get elements starting from the first element less than its position
              
            var numbersFromFirstLessThanPosition = numbers
                    .SkipWhile((n, index) => n >= index);

                foreach (var num in numbersFromFirstLessThanPosition)
                {
                    Console.WriteLine(num);
                }
       


    #endregion


}
    }
    }


