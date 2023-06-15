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
        
        string[] result=new string[100];
        result=_reversSentence(string3);
        Write("the rever of "+ string3 +" is: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Write(result[i] + ' ');
        }
       WriteLine();

        WriteLine("*************************************************");
        WriteLine("enter string");
        string string4 = Convert.ToString(ReadLine());
        WriteLine("enter target char to be replaced");
        char targit = Convert.ToChar(ReadLine());
        WriteLine("which cahr you want to  replac it with");
        char replace = Convert.ToChar(ReadLine());

        WriteLine(_replacementoFcharacter(string4, targit, replace));




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

    /*
     * Problem 4: Replace Characters
    Write a function that takes a string, a target character, 
    and a replacement character as inputs. The function should 
    replace all occurrences of the target character with the 
    replacement character in the string. For example, if the 
    input string is "Hello World", the target character is 'o',
    and the replacement character is 'a', the function should return "Hella Warld".

     
     */

    static string _replacementoFcharacter(string string4,char target,char replace)
    {
      
        string totl = string4.Replace(target, replace);
        return totl;
    }


}