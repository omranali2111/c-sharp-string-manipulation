using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using static System.Console;
internal class Program
{
   
    private static void Main(string[] args)


    {
        WriteLine("enter string");
        string string1= Convert.ToString(ReadLine());
        WriteLine("the revers of the string is "+reversString(string1));
        WriteLine("*************************************************");
        WriteLine("enter string");
        string string2 = Convert.ToString(ReadLine());
        WriteLine("the number of Vowels in this string  is " + _countVowels(string2));
        WriteLine("*************************************************");
        WriteLine("enter string");
        string string3 = Convert.ToString(ReadLine());
        
        string[] result=new string[3];
        result=_reversSentence(string3);
        Write("the rever of "+ string3 +" is: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Write(result[i] + ' ');
        }
       WriteLine();


    }

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

    /*
       Problem 2: Count Vowels
       Write a function that takes a string as input
       and counts the number of vowels(a, e, i, o, u) 
       present in the string.For example, if the input is
       "Open", the function should return 2.
       */

    static int _countVowels(string string2)
    {
        int count = 0;
        for (int i = 0; i < string2.Length; i++)
        {

            if (string2[i] == 'a' || string2[i] == 'e' || string2[i] == 'i' || string2[i] == 'o' || string2[i] == 'u')
            {
                count++;
            }

        }
        return count;
    }

    /*
    Problem 3: Reverse Words in a String
    Write a function that takes a sentence as input and 
    reverses the order of the words.For example, if 
    the input is "Hello World", the function should 
    return "World Hello".
   */

    static string[] _reversSentence(string string3)

    {
       
        string[] result = new string[100];
        string tempStr = string.Empty;//blank string
        int arrayIndex = 0;
        for (int i = 0; i < string3.Length; i++)
        {
            tempStr += string3[i].ToString();
            if (string3[i] != ' ')
            {
                result[arrayIndex] = tempStr;
            }
            else
            {
                tempStr = "";
                arrayIndex++;
            }
        }


        return result;

    }

}