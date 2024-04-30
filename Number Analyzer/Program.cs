using System.ComponentModel.Design;

Console.WriteLine("Enter a number between [1, 100]");
int value = int.Parse(Console.ReadLine());


    if (value % 2 == 1 && value < 60)
{
    Console.WriteLine(value + " Odd and less than 60.");
}
else if (value % 2 == 0 && value >= 2 && value <= 24)
{
    Console.WriteLine("Even and less than 25.");
}
else if (value % 2 == 0 && value >= 26 && value <=60)
{ 
    Console.WriteLine("Even and between 26 and 60 inclusive.");
}
else if (value % 2 == 0 && value > 60)
{
    Console.WriteLine("Even and greater than 60.");
}
else if (value % 2 == 1 && value > 60)
{
    Console.WriteLine("Odd and greater than 60.");
}

bool keeplooping = true;
while (keeplooping)
{
    Console.WriteLine("Do you want to continue? y/n");
    string loopchoice = Console.ReadLine();
    if (loopchoice == "n")
    {
        keeplooping = false;
    }
    else if (loopchoice == "y")
    {
        keeplooping = true;
    }
}

