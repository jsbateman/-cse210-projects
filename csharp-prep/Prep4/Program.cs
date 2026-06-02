using System; 
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        {List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, when done type 0.");
        Console.WriteLine("Enter a number:");
        string number_list = Console.ReadLine();
        int number_list_int =int.Parse(number_list);
        if (number_list_int != 0)
        {numbers.Add (number_list_int);
        for (int i = 0; i < numbers.Count; i++)
        Console.WriteLine(numbers[i]);
};
        
    
    }   
}}