namespace Day01LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly typed local variable
            #region var
            //string Data = "Ahmed"; 
            var Data = "Ahmed";
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
            #endregion
        }
    }
}
