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
            Data = null;
            //Data = 5; 
            // Invalid 
            // After Intialization, You Can't Change Variable Datatype 
            //var X; // Invalid 
            // Var Must be Intialize 
            Data "May";
            #endregion
            #endregion
        }
    }
}
