using System.Text.RegularExpressions;

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
              List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
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
            #endregion
        }
    }
}
