using System;

// String ustida amallar
string txt = "teLefOn";
int x = 13;
if (x > txt.Length)
{
    Console.WriteLine(txt.ToUpper());
}
else
{
    Console.WriteLine(txt.ToLower());
}

string txt1 = "komPyuter";
int x1 = 4;
if (x1 > txt.Length)
{
    Console.WriteLine(txt1.ToUpper());
}
else
{
    Console.WriteLine(txt1.ToLower());
}

// Ternary operator yordamida ifodalangan qiymatni if-else yordamida ifodalash
int x = t;
int y = 10;

if (x > y)
{
    System.Console.WriteLine("x greater than y");
}
else if (x < y)
{
    System.Console.WriteLine(" x less than y");
}
else if (x == y)
{
    System.Console.WriteLine("x equal to y");
}
else
{
    System.Console.WriteLine("x and y are not comparable");
}


// Switch expression
string name = Console.ReadLine();

switch (name)
{
    case "Dushanba":
        Console.WriteLine("Monday");
        break;
    case "Seshanba":
        Console.WriteLine("Tuesday");
        break;
    case "Chorshanba":
        Console.WriteLine("Wednesday");
        break;
    case "Payshanba":
        Console.WriteLine("Thursday");
        break;
    case "Juma":
        Console.WriteLine("Friday");
        break;
    case "Shanba":
        Console.WriteLine("Saturday");
        break;
    case "Yakshanba":
        Console.WriteLine("Sunday");
        break;
}




