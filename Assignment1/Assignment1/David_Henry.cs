using System.Reflection.Metadata;

int income;

int rent;
int food;
int entertainment;

int expenses;
int balance;
int investment;

int pin = 1234;
bool login = false;

string userWrites = "";
int userInput;

//user login
while (!login)
{
    Console.WriteLine("Please enter your pin to login");
    userInput = Convert.ToInt32(Console.ReadLine());

    if (userInput == pin)
    {
        Console.WriteLine("Login Successful!");
        login = true;
    }
    else
    {
        Console.WriteLine("Login Failed. Please try again.");
    }
}

if (login)
{
    //get income
    Console.WriteLine("Please enter your monthly income");
    userInput = Convert.ToInt32(Console.ReadLine());
    income = userInput;

    //get rent costs
    Console.WriteLine("Please enter your monthly rent");
    userInput = Convert.ToInt32(Console.ReadLine());
    rent = userInput;

    //get food costs
    Console.WriteLine("Please enter your monthly food costs");
    userInput = Convert.ToInt32(Console.ReadLine());
    food = userInput;

    //get enterainment costs
    Console.WriteLine("Please enter your monthly entertainment costs");
    userInput = Convert.ToInt32(Console.ReadLine());
    entertainment = userInput;

    //calculaate balance
    expenses = rent + food + entertainment;
    balance = income - expenses;

    //output results
    Console.WriteLine($"your income, expenses, and balance is {income}, {expenses}, and {balance}, respectively");

    if (balance < 0)
    {
        Console.WriteLine("You are overspending. Consider reducing some expenses.");
    }
    else if (balance >= 0 && balance <= 500)
    {
        Console.WriteLine("Your budget is tight. Spend carefully");
    }
    else
    {
        Console.WriteLine("You have some money left to save or invest. Do you want to invest 10% of your income? y/n ?");
        userWrites = Console.ReadLine();

        if (userWrites == "y")
        {
            investment = balance / 10;
            balance -= investment;
            Console.WriteLine($"We have invested {investment}, your balance is now {balance}");
        }
        else
        {
            Console.WriteLine("No problem, your balance remains the same.");
        }
    }
}
