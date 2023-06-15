using static System.Console;
internal class Program
{
   
    private static void Main(string[] args)


    {
        WriteLine("enter string");
        string string1= Convert.ToString(ReadLine());
       

        WriteLine("the revers of the string is "+reversString(string1));

       
        /*
        Problem 1: Reverse a String
        Write a function that takes a string as input and returns 
        the reverse of that string.For example, if the input
        is "Hello", the function should return "olleH".Without 
        using the built-in functions
        */

        static string reversString(string string1)

        {
            string revstring = string.Empty;//blank string
            for (int i = string1.Length - 1; i >= 0; i--)
            {

                revstring += string1[i];


            }


            return revstring;

        }
    }
}