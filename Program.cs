using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi enter the word to check for as palindrome");
        string check = Console.ReadLine();
        char[] arr1 = check.ToCharArray();
        char[] arr2 = arr1.Reverse().ToArray();
        string stringToCompare = String.Concat(arr2);
       Console.WriteLine( String.Equals(check,stringToCompare)? "This is a palindrome": "This is not a palindrome");
        Console.ReadLine();


    }
    
}