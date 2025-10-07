using System.ComponentModel.DataAnnotations;

string[] webPages = { "Home", "About", "News", "Contact" };
float[] pageHits = new float[webPages.Length];
float allHits = 0f;

float[] percentage = new float[webPages.Length];
float precentDisp = 0;

float highestPage = 0f;
int highestPageIndex = 0;

int visitors;


//welcome message
Console.WriteLine("Welcome to the website Visitor Tracker!");
Console.WriteLine("Enter the number of visitors today: ");

//get number of visitors
visitors = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Menu of pages:");

//get all web page names and display them for user
for (int i = 0; i < webPages.Length; i++)
{
    Console.WriteLine((i + 1) + ") " + webPages[i]);
}

//enter each visitor's desired page
for (int i = 0; i < visitors; i++)
{
    int hit;
    Console.WriteLine("Visitor " + (i + 1) + ": Enter page number (1 - 4): ");
    hit = Convert.ToInt32(Console.ReadLine());
    pageHits[hit - 1] += 1;
    allHits += 1;
}

Console.WriteLine("--- Website Analytics Report ---");

//add up all visits
for (int i = 0; i < webPages.Length; i++)
{
    percentage[i] = pageHits[i] / allHits;
    precentDisp = percentage[i] * 100f;

    Console.WriteLine(webPages[i] + ": " + pageHits[i] + " visits" + " (" + precentDisp + "%)");
}

//display highest visited page
for (int i = 0; i < webPages.Length; i++)
{
    if (percentage[i] > highestPage)
    {
        highestPage = percentage[i];
    }
    else
    {
        highestPage = highestPage;
    }
}
highestPageIndex = Convert.ToInt32(highestPage);
Console.WriteLine("Most Popular Page: " + webPages[highestPageIndex]);