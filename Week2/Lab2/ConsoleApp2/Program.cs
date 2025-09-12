/*float monsterHealth = 50f;
float monsterDef = 0.8f;
float playerDamage;

Console.Write("Input your damage: ");

playerDamage = Convert.ToInt32(Console.ReadLine()) * monsterDef;

monsterHealth -= playerDamage;

Console.WriteLine("Hit! You did " + playerDamage + " damage! Monster Health is now " + monsterHealth + ".");*/

int curHealth = 30; 
int maxHealth = 100;

int healPotVal = 20;
int potsUsed;
int healing;

Console.Write("How many potions do you want to use? ");
potsUsed = Convert.ToInt32(Console.ReadLine());
healing = healPotVal * potsUsed;
curHealth += healing;

if (curHealth + healing > maxHealth)
{
    curHealth = maxHealth;
}

if (curHealth + healing <= maxHealth)
{
    curHealth += healing;
}

Console.WriteLine("You drank " + potsUsed + " potions, healing you for " + healing + "!");
Console.WriteLine("Your health is now " + curHealth + "!");