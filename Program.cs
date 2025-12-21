using System.Net.NetworkInformation;
using System.IO;


Random rnd = new Random();
string name = "";
string path = @"";
int ageDice = rnd.Next(15,90);
int dice = rnd.Next(1,20);


string[] gender = {"Female", "Male", "Non-Binary", "Non specified", "Will add later"};
int selectedGender;
string[] personalityTrait = {"Introverted", "Extroverted", "Ambiverted", "Wildcard", "Will add later"};
int selectedPersonalityTrait;
string[] desires = {"Power", "Wealth", "Calmness", "Chaos", "Peace", "None", "Will add later"};
int selectedDesire;
string[] beliefe = {"Higher Power", "Humanity", "Control", "Chaos Theory", "Kindness", "Nothing", "Will add later"};
int selectedBelife;
string[] dislikes = {"Religion", "Greed", "Bonfires", "Chaos", "Peace", "Evil", "Happiness", "Will add later"};
//string savedCharachters = File.ReadAllText("/home/FuxiT/Documents/Character-Generator/Charachters/");
int selectedDislikes;
int stammina;
int charisma;
int strength;
int durability;
int luck;
int recklessness;
int stubborness;
string country = "";

int education;
int intelligence; 
int age;
string description = "";

int exitOption;


bool teen = false;
bool youngAdult = false;
bool adult = false;
bool old = false;
bool validName = false;


Console.Clear();

Console.WriteLine("Choose a name for your charachter");


while (!validName)
{
    
    name = Console.ReadLine()!;
    if (name == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You must type in a name");
        Console.ResetColor();
    }
    else
    {
        validName = true;
    }
}
path = "/home/FuxiT/Documents/Character-Generator/Charachters/" + name;

if (File.Exists(path))
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Heads up!");
    Console.WriteLine("A charachter with this name already exists!");
   // Console.WriteLine(savedCharachters, name);
    Console.WriteLine("Saving this will override the existing file with the same name");
    Console.ResetColor();
    Console.WriteLine("1.Continue / 2.Exit program"); 

    exitOption = int.Parse(Console.ReadLine()!);
    switch (exitOption)
    {
        case 1:

        break;

        case 2:
            Environment.Exit(0);
        break;

        default:
            Console.WriteLine("Invalid");
        break;

    }


}


Console.Clear();
Console.WriteLine("Where is your character from? (optional)");
country = Console.ReadLine()!;



//Gender
Console.Clear();
Console.WriteLine("Choose a gender");
for (int i = 0; i < gender.Length; i++)
{
    Console.WriteLine(i+1 + " " + gender[i]);
}
selectedGender = int.Parse(Console.ReadLine()!);

Console.ReadKey();



//Trait
Console.Clear();
Console.WriteLine("Choose personality trait");
for (int i = 0; i < personalityTrait.Length; i++)
{
    Console.WriteLine(i+1 + " " + personalityTrait[i]);
}
selectedPersonalityTrait = int.Parse(Console.ReadLine()!);



//Desire
Console.Clear();
Console.WriteLine("What does your character desire?");
for (int i = 0; i < desires.Length; i++)
{
    Console.WriteLine(i+1 + " " + desires[i]);
}
selectedDesire = int.Parse(Console.ReadLine()!);



//Belives in
Console.Clear();
Console.WriteLine("What does you character belive in?");
for (int i = 0; i < beliefe.Length; i++)
{
    Console.WriteLine(i+1 + " " + beliefe[i]);
}
selectedBelife = int.Parse(Console.ReadLine()!);



//Dislikes
Console.Clear();
Console.WriteLine("What does your character dislike?");
for (int i = 0; i < dislikes.Length; i++)
{
    Console.WriteLine(i+1 + " " + dislikes[i]);
}
selectedDislikes = int.Parse(Console.ReadLine()!);



void RollDice()
{
    dice = rnd.Next(1,20);
    for (int i = 0; i < dice; i++)
    {
        Console.Write("¤");
        Thread.Sleep(100);
        if (i == dice)
        {
            break;
        }
    }
}

void Stammina()
{
    Console.WriteLine("Rolling stammina...");
    RollDice();
    stammina = dice*5;
    Console.WriteLine("\nStammina: "+ stammina);
    Console.WriteLine("");

}

void Strength()
{
    Console.WriteLine("Rolling strength...");
    RollDice();
    strength = dice*4;
    Console.WriteLine("\nStrength: "+ strength);
    Console.WriteLine("");

}

void Charisma()
{
    Console.WriteLine("Rolling charisma...");
    RollDice();
    charisma = dice*5;
    Console.WriteLine("\nCharisma: "+ charisma);
    Console.WriteLine("");

}


void Education()
{
    Console.WriteLine("Rolling education...");
    RollDice();
    education = dice*4;
    Console.WriteLine("\nEducation: " + education);
    Console.WriteLine("");

}

void Intelligence()
{
    Console.WriteLine("Rolling intelligence...");
    RollDice();
    intelligence = education+dice;
    Console.WriteLine("\nIntelligence: " + intelligence);}
    Console.WriteLine("");


void Luck()
{

    Console.WriteLine("Rolling luck...");
    RollDice();
    luck = dice*5;
    Console.WriteLine("\nLuck: " + luck);
    Console.WriteLine("");

}

void Recklessness()
{

    Console.WriteLine("Rolling recklessness...");
    RollDice();
    recklessness = dice*5;
    Console.WriteLine("\nRecklessness: " + recklessness);
    Console.WriteLine("");

}

void Stubborness()
{

    Console.WriteLine("Rolling stubborness...");
    RollDice();
    stubborness = dice*5;
    Console.WriteLine("\nStubborness: " + stubborness);
    Console.WriteLine("");
}


void RollAge()
{
    for (int i = 0; i < ageDice; i++)
    {
        Console.Write("¤");
        Thread.Sleep(100);
        if (i == ageDice)
        {
            break;
        }
    }
}

void Age()
{   

    Console.WriteLine("Roll dice for age!");    
    Console.ReadKey();
    RollAge();
    Console.WriteLine("\n"+ ageDice);
    age = ageDice;

    if (age < 20)
    {
        teen = true;
    }
    
    else if (age > 20 && age < 34)
    {
        youngAdult = true;
    }

    else if (age > 34 && age < 59)
    {
        adult = true;
    }

    else if (age > 59)
    {
        old = true;
    }
}

Console.Clear();
Stammina();
Strength();
durability = stammina + strength / 4;
Console.WriteLine("Durability: " + durability);
Console.WriteLine("");
Charisma();
Education();
Intelligence();
Console.WriteLine("");
Luck();
Recklessness();
Stubborness();
Console.ReadKey();

Console.Clear();

Console.WriteLine("Name: " + name);
Console.WriteLine("From: " + country);
Console.WriteLine("Gender: " + gender[selectedGender-1]);
Console.WriteLine("Personality Trait: " + personalityTrait[selectedPersonalityTrait-1]);
Console.WriteLine("Desire: " + desires[selectedDesire-1]);
Console.WriteLine("Belives in: " + beliefe[selectedBelife-1]);
Console.WriteLine("Dislikes: " + dislikes[selectedDislikes-1]);
Console.WriteLine("Stammina: " + stammina);
Console.WriteLine("Strength: " + strength);
Console.WriteLine("Durability: " + durability);
Console.WriteLine("Charisma: " + charisma);
Console.WriteLine("Education: " + education);
Console.WriteLine("Intelligence: " + intelligence);
Console.WriteLine("Luck: " + luck);
Console.WriteLine("Recklessness: " + recklessness);
Console.WriteLine("Stubborness: " + stubborness);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nNow lets change the values by rolling your age");
Console.ResetColor();
Age();

if (teen)
{
    stammina += 40;
    strength -= 10;
    durability = stammina + strength / 2;
    charisma -= 30;
    education -= 30;
    intelligence /= 2;
    recklessness += 20;
    stubborness += 20;
    Console.WriteLine("Teen");
}

else if (youngAdult)
{
    stammina += 40;
    strength += 40;
    durability = stammina + strength / 4;
    charisma += 10;
    education += 30;
    intelligence -= 10;
    stubborness -= 20;
    Console.WriteLine("Young Adult");

}

else if (adult)
{
    stammina += 10;
    strength += 20;
    durability = stammina + strength / 2;
    charisma += 30;
    education += 30;
    intelligence += 20;
    stubborness += 30;
    Console.WriteLine("Adult");

}

else if (old)
{
    stammina /= 2;
    strength /= 2;
    durability = stammina - strength + 10;
    education -= 10;
    intelligence *= 2;
    stubborness *= 2;
    Console.WriteLine("Old");

}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Write a short description about your character (optional)");
description = Console.ReadLine()!;
Console.ResetColor();


Console.WriteLine("Name: " + name);
Console.WriteLine("From: " + country);
Console.WriteLine("Gender: " + gender[selectedGender-1]);
Console.WriteLine("Personality Trait: " + personalityTrait[selectedPersonalityTrait-1]);
Console.WriteLine("Desire: " + desires[selectedDesire-1]);
Console.WriteLine("Belives in: " + beliefe[selectedBelife-1]);
Console.WriteLine("Dislikes: " + dislikes[selectedDislikes-1]);
Console.WriteLine("Age: " + age);
Console.WriteLine("Stammina: " + stammina);
Console.WriteLine("Strength: " + strength);
Console.WriteLine("Durability: " + durability);
Console.WriteLine("Charisma " + charisma);
Console.WriteLine("Education: " + education);
Console.WriteLine("Intelligence: " + intelligence);
Console.WriteLine("Luck: " + luck);
Console.WriteLine("Recklessness: " + recklessness);
Console.WriteLine("Stubborness: " + stubborness);
Console.WriteLine("Description: " + description);




bool saveOption = false;


while (!saveOption)
{
    Console.WriteLine("Save [y/n]");
    string save = Console.ReadLine()!;
    
    if (save == "y" || save == "Y")
    {
        File.WriteAllText(path, "Name: " + name +
        "\nFrom: " + country +
        "\nGender: " + gender[selectedGender-1] +
        "\nPersonality Trait: " + personalityTrait[selectedPersonalityTrait-1] +
        "\nDesire: " + desires[selectedDesire] +
        "\nBelives in: " + beliefe[selectedBelife] +
        "\nDislike: " + dislikes[selectedDislikes] +
        "\nAge: " + age +
        "\nStammina: " + stammina +
        "\nStrength: " + strength +
        "\nDurability: " + durability + 
        "\nCharisma: " + charisma +
        "\nEducation: " + education +
        "\nIntelligance: " + intelligence +
        "\nLuck: " + luck +
        "\nRecklessness: " + recklessness +
        "\nStubborness: " + stubborness +
        "\nDescripton: '" + description+ "'"  +
        "\nDesire: " + desires[selectedDesire-1] +
        "\nBelives in: " + beliefe[selectedBelife-1] +
        "\nDislikes: " + dislikes[selectedDislikes-1]
        );

        Console.WriteLine("Saved as " + name + ".txt in " + path);
        saveOption = true;
        Environment.Exit(0);
    }

    else if (save == "n" || save == "N")
    {
        Console.WriteLine("Didn't save");
        saveOption = true;
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Invalid input");
        Console.ReadKey();
    }

    Console.WriteLine("Thanks for playing!");
}