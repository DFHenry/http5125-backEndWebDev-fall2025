int minYear = 2008;
int curYear = 2025;
int userYear;

string password = "password";
string passEntry;

Console.WriteLine("Please enter the year you were born.");

userYear = Convert.ToInt32(Console.ReadLine());

if (userYear <= minYear)
{
    Console.WriteLine("Age confirmed! Please enter password");
    passEntry = Console.ReadLine();

    if (passEntry == password)
    {
        Console.WriteLine("Password verified. Welcome into the server!");
    }
    else if (passEntry != password)
    {
        Console.WriteLine("Password incorrect. Entry denied.");
    }
}

else if (userYear > curYear)
{
    Console.WriteLine("Invalid entry!");
}

else if (userYear > minYear)
{
    Console.WriteLine("Sorry, you are not verified as an adult.");
}