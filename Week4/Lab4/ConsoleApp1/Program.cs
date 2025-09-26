//Lab 4 Part 1

/*int userInput;

int standard = 16;
int elite = 21;
int premium = 51;

string standardString = "Standard";
string eliteString = "Elite";
string premiumString = "Premium";

bool packageChosen = false;
string selectedPackage="";
int selectedPackageCost=0;

Console.WriteLine("Select the plan that you want:");
Console.WriteLine("   1) Standard: $16");
Console.WriteLine("   2) Elite: $21");
Console.WriteLine("   3) Premiun: $51");

while (!packageChosen)
{
    userInput = Convert.ToInt32(Console.ReadLine());

    switch (userInput)
    {
        case 1:
            Console.WriteLine("Standard package selected.");
            selectedPackage = "Standard";
            selectedPackageCost = standard;
            packageChosen = true;
            break;
        case 2:
            Console.WriteLine("Elite package selected.");
            selectedPackage = "Elite";
            selectedPackageCost = elite;
            packageChosen = true;
            break;
        case 3:
            Console.WriteLine("Premium package selected.");
            selectedPackage = "Premium";
            selectedPackageCost = premium;
            packageChosen = true;
            break;
        default:
            Console.WriteLine("Invalid Input. Please try again.");
            break;
    }
}

Console.WriteLine("Please type your budget");

userInput = Convert.ToInt32(Console.ReadLine());

if (userInput >= selectedPackageCost)
{
    Console.WriteLine("You have successfully signed up for the " + selectedPackage + " plan!");
}
else if (userInput < selectedPackageCost)
{
    Console.WriteLine("Sorry, you do not have the funds for this package.");
}*/

// Lab 4 Part 2

string userInput;
string password = "password";

int maxAttempts = 3;
bool passLoop = false;
bool passPositive = false;

while (!passLoop)
{
    for (int i = 0; i < maxAttempts; i++)
    {
        Console.WriteLine("Please Enter Your Password");
        userInput = Console.ReadLine();

        if (userInput == password)
        {
            passPositive = true;
            break;
        }
        else
        {
            Console.WriteLine("Invalid password, please try again!");
        }
    }
    passLoop = true;
}

if (passPositive)
{
    Console.WriteLine("You Logged In. Welcome!");
}
else
{
    Console.WriteLine("Login Attempts exceeded. Access Denied!");
}