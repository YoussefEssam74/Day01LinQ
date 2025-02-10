using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using static Day01LinQ.ListGenerator;
using System.Linq; 

namespace Day01LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly typed local variable
            #region var
            //string Data = "Ahmed"; 
            //var Data = "Ahmed";
            // Implicit Type 
            // Complier Will Detect The Datatype Of Variable at Compilation Time 
            // Based On its Intial Value 
            //var X = null; 
            // Invalid 
            // Var Can't be Intialized With Null 
            // Data = null;
            //Data = 5; 
            // Invalid 
            // After Intialization, You Can't Change Variable Datatype 
            //var X; // Invalid 
            // Var Must be Intialize 
            // Data "May";
            #endregion
            #region dynamic
            //dynamic Data = "Ali"; 
            //// CLR Will Detect Datatype Of Variable At Runtime 
            //// Based On It's Last Assigned Value 
            //dynamic X; // Valid 
            //// Can Declare Variable With Dynamic Without Intialization 
            //dynamic Y = null; // Valid 
            //// Can Be Intialized With Null 
            //Data = 2; 
            //// After Intialization, You Can Change Datatype Of Variable 
            //Data = true; 
            //Data = 3.3; 
            //Data = 'A';
            #endregion
            #region Extention Method
            // int x = 12345;
            // int y =x.Reverse();
            // Console.WriteLine(y); 
            #endregion
            #region Anonymous Type
            ////Employee employee = new Employee() { Id = 10, Name = "Mona", Salary = 1000}; 
            ////object Emp01 = new { Id = 20, Name = "Ahmed", Salary = 5000 }; 
            ////Console.WriteLine(Emp01. Salary); 
            //// Invalid 
            //int X = 5;
            //Console.WriteLine(X.GetType().Name);
            //// Int32 
            //var Emp03 = new { Id = 10, Name = "Mona", Salary = 1000 };
            //Console.WriteLine(Emp03.GetType().Name);// Anonymous Type0'3 
            //// Object That Will be Created From Anonymous Type Is An Immutable Object [Can not be changed]
            //Console.WriteLine(Emp03.GetType().Name); // Anonymous Type0'3 
            //Console.WriteLine(Emp03.Salary); // 1000 
            //                                 //Emp03.Salary = 2000; // Invalid 
            //var Emp04 = new { Id = Emp03.Id, Name = Emp03.Name, Salary = 2000 }; // Till C# 9 
            //var Emp05 = Emp03 with { Salary = 2000 };//c# 10 .net 6
            //Console.WriteLine($"Emp 03 = {Emp03.GetType().Name}"); ; // Anonymous Type0'3 
            //Console.WriteLine($"Emp 04 = {Emp04.GetType().Name}"); ; // Anonymous Type0'3 
            //Console.WriteLine($"Emp 05 = {Emp05.GetType().Name}"); ; // Anonymous Type0'3 

            //// The Same Anonymous Type As Long As : I 
            //// 1. Same Properties Name [Case Sensitive] 
            //// 2. Same Properties Order 
            //var Emp06 = new { Name = "Omar", Salary = 5000, Id = 70 };
            //Console.WriteLine($"Emp 06 = {Emp06.GetType().Name}"); // _Anonymous Type1'3 
            //var Emp07 = new { Id = 70, Name = "Salma" };
            //Console.WriteLine($"Emp 07 = {Emp07.GetType().Name}");// Anonymous Type2 2

            #endregion
            #endregion
            #region what is a linq
            // LINQ => Langauge Integrated Query 
            // LINQ +40 Extension Methods 
            // Extension Methods For All Collection That Impelment Interface "IEnumerable" 
            // Named As LINQ Operators Existed At Class Enumerable 
            // Categorized into 13 Category 
            // List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // List<int> OddNumbers = Numbers.Where(Num => Num % 2 == 1).ToList();
            //foreach (int num in OddNumbers)
            //{
            //    Console.WriteLine($"{num} ");

            //}
            // You Can Use "LINQ Operator" Against The Data [Stored In Sequence] 
            // Regardless Data Store [Sql Server, Oracle MySql] 
            // Sequence -> The Object From Class That Impelment Built In Interface "IEnumerable" 
            // 1. Local -> Static [L20bject], XML File [L2XML] 
            // 2. Remote  -> L2EF
            #endregion
            #region linq syntax [fluent,query syntax]
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // // 1.1 Call "LINQ Operators" as Static Method
            //  var OddNumbers = Enumerable. Where(Numbers, X => X % 2 ==1);
            //  //1.2 Call "LINQ Operators" As Extension Method [Recommended] 
            //  OddNumbers = Numbers.Where(X => X % 2 == 1);
            //  foreach (var number in OddNumbers)
            //  {
            //      Console.Write($"{number} "); // 13579 
            //  }
            #endregion
            #region query syntax like sql style
            // 3. Select * 
            // 1. From Numbers N 
            // 2. Where N % 2 == 1 
            //   var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;
            //foreach (var Number in OddNumbers)
            //{
            //    Console.Write($"{Number} "); // 13579
            //}
            // Must be Begin With Keyword "From" I
            //  Must Be End With Select OR GroupBy
            #endregion
            #region Deffered Execution [latest version of data]
            // List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // var OddNumbers = Numbers.Where(X => X % 2 == 1); //13579 
            // Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            // // Where Is Executed With Deferred Execution 
            // foreach (var number in OddNumbers)
            // {
            //     Console.Write($"{number} "); // 13579
            // }

            #endregion
            #region Immediate Execution [Elements Opertors, Casting Operators, Aggregate Operators]
            //  List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //  var OddNumbers = Numbers.Where(X => X % 2 == 1).ToList(); //13579 
            //  Numbers.AddRange(new int[] { 11, 12, 13, 14, 15});
            //  // Where Is Executed With Deferred Execution 
            //  foreach (var number in OddNumbers)
            //  {
            //      Console.Write($"{number} "); // 13579
            //  }
            #endregion
            #region data setup
            //Console.WriteLine(ProductsList[0]);
            //Console.WriteLine(CustomersList[0]); 
            #endregion
            #region Get Products Out Of Stock 
            ////// Fluent Syntax 
            //var Result = ProductsList.Where(P => P. UnitsInStock == 0);
            ////// Query Syntax 
            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0
            //         select P; 

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region ex02
            // var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");
            // // Query Syntax 
            // Result = from P in ProductsList
            //          where P. UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //         select P;
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion





            /*---------------------------------------*/
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            // var outOfStockProducts = ProductsList.Where(p => p.UnitsInStock == 0);
            // Console.WriteLine("Out of stock products:");
            // foreach (var product in outOfStockProducts)
            // {
            //     Console.WriteLine(product);
            // }

            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var expensiveProducts = from p in ProductsList
            //                               where p.UnitsInStock > 0 && p.UnitPrice > 3m
            //                               select p;
            //
            //foreach (var product in expensiveProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //
            // var result = Arr
            //     .Select((name, index) => new { Digit = index, NameLength = name.Length }) 
            //     .Where(d => d.NameLength < d.Digit) 
            //     .Select(d => d.Digit) 
            //     .ToList();
            //
            // Console.WriteLine("Digits whose name is shorter than their value:");
            // Console.WriteLine(string.Join(", ", result));

            #endregion
            #endregion
            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            var firstOutOfStock = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);


            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            var expensiveProduct = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

            #endregion
            #region 3. Retrieve the second number greater than 5 


            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region 1. Count the Number of Odd Numbers in the Array
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //
            // var oddCount = Arr.Count(n => n % 2 != 0);
            //
            // Console.WriteLine($"Number of odd numbers: {oddCount}");


            #endregion
            #region 2. Return a List of Customers and How Many Orders Each Has
            //var customerOrderCounts = CustomersList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Count() });
            //
            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine(customer);
            //}

            #endregion
            #region 3. Return a List of Categories and How Many Products Each Has
            // var categoryProductCounts = ProductsList
            //     .GroupBy(p => p.Category)
            //     .Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //
            // foreach (var category in categoryProductCounts)
            // {
            //     Console.WriteLine(category); 
            // }

            #endregion
            #region 4. Get the Total of the Numbers in an Array
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //
            // int totalSum = Arr.Sum();
            //
            // Console.WriteLine($"Total sum: {totalSum}");

            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            // int totalCharacters = words.Sum(word => word.Length);
            // Console.WriteLine($"Total number of characters: {totalCharacters}");



            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // int shortestWordLength = words.Min(word => word.Length);
            //
            // Console.WriteLine($"Shortest word length: {shortestWordLength}");
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int longestWordLength = words.Max(word => word.Length);
            //
            //Console.WriteLine($"Longest word length: {longestWordLength}");


            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //double averageWordLength = words.Average(word => word.Length);
            //
            //Console.WriteLine($"Average word length: {averageWordLength:F2}");


            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name

            // var sortedProducts = ProductsList.OrderBy(p => p.ProductName).ToList();
            // foreach (var product in sortedProducts)
            // {
            //     Console.WriteLine(product.ProductName);
            // }

            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //
            //var sortedWords = arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            // var sortedByStock = ProductsList.OrderByDescending(p => p.UnitsInStock);
            // foreach (var product in sortedByStock)
            // {
            //     Console.WriteLine(product);
            // }

            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            // string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //
            // var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            // foreach (var digit in sortedDigits)
            // {
            //     Console.WriteLine(digit);
            // }


            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            // string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //
            // var sortedWords = arr.OrderBy(word => word.Length)
            //          .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            // foreach (var word in sortedWords)
            // {
            //     Console.WriteLine(word);
            // }

            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var sortedProducts = ProductsList.OrderBy(p => p.Category)
            //                     .ThenByDescending(p => p.UnitPrice);
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = arr.OrderBy(word => word.Length)
            //         .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //  string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //
            // var filteredDigits = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            // foreach (var digit in filteredDigits)
            // {
            //     Console.WriteLine(digit);
            // }


            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.

            // var productNames = ProductsList.Select(p => p.ProductName);
            // Console.WriteLine("Product Names:");
            // Console.WriteLine(string.Join(", ", productNames));
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            // string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            // var wordVariations = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            //
            // Console.WriteLine("Uppercase and Lowercase Word Variations:");
            // foreach (var word in wordVariations)
            // {
            //     Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            // }
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            // var productInfo = ProductsList.Select(p => new
            //{
            //    p.ProductName,
            //    Price = p.UnitPrice,  // Renamed property
            //    p.Category
            //});
            //
            //Console.WriteLine("Product Info (Renamed UnitPrice to Price):");
            //foreach (var p in productInfo)
            //{
            //    Console.WriteLine($"Name: {p.ProductName}, Price: ${p.Price}, Category: {p.Category}");
            //}

            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //
            //Console.WriteLine("Number: In-place?");
            //foreach (var item in Arr.Select((value, index) => new { Value = value, InPlace = value == index }))
            //{
            //    Console.WriteLine($"{item.Value}: {item.InPlace}");
            //}
            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //
            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select (a, b);
            //
            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}

            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            //var lowValueOrders = ProductsList.Where(o => o.UnitPrice < 500.00m);
            //
            // Console.WriteLine("Orders with total less than 500.00:");
            // foreach (var order in lowValueOrders)
            // {
            //     Console.WriteLine(order);
            // }


            #endregion
            #endregion




        }
        }
}
