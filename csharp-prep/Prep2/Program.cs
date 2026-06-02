using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("What is your grade? ");
    string grade = Console.ReadLine();
    float gradenumber = float.Parse(grade);
    string letter = "";
    if (gradenumber >= 90)
    {letter = "A";
    }
    else if (gradenumber >= 80)
    {letter = "B";
    }
    else if (gradenumber >= 70)
    {letter = "C";
    }
    else if (gradenumber >= 60)
    {letter = "D";}
    else
    {letter = "F";}

    if (gradenumber >= 70)
     {Console.WriteLine("You passed!");}
     else
     {Console.WriteLine("Try again you can do it! ");}
    
     {Console.WriteLine($"{letter}");}}}