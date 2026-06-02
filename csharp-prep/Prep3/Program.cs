using System;

class Program
{
    static void Main(string[] args)
    {Console.WriteLine("What is your magic number? ");
    string magicnumber = Console.ReadLine();
    int int_magicnumber = int.Parse(magicnumber);
    string flag = "false";
    if (flag == "false")
    {do{Console.WriteLine("What is your guess? ");
    string guess =Console.ReadLine();
    int int_guess = int.Parse(guess);
    if (magicnumber == guess)
    flag = "true";  
    else if(int_magicnumber < int_guess)
    {Console.WriteLine("Too high.");}
    else if (int_magicnumber > int_guess)
    {Console.WriteLine("Too low.");} 
    while (int_magicnumber != int_guess);}while (flag == "false");}
    if (flag == "true")
    {Console.WriteLine("You guessed it!");}}}