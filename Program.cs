using System.Net.NetworkInformation;

Random rnd = new Random();
string name = "";
string path = @"";
int ageDice = rnd.Next(15,90);
int dice = rnd.Next(1,20);


string[] gender = {"Female", "Male", "Non-Binary", "Non specified"};
int selectedGender;
int stammina;
int charisma;
int strength;
int durability;
int education;
int intelligence; 
int weaponSkill;
int age;

int exitOption;


bool teen = false;
bool youngAdult = false;
bool adult = false;
bool old = false;


Console.Clear();
Console.WriteLine("Choose a name for your charachter");

name = Console.ReadLine()!;
path = "/home/leinarsson/Documents/Programmering/Charachter Generator/Charachters/" + name;

if (File.Exists(path))
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Heads up!");
    Console.WriteLine("A charachter with this name already exists!");
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
Console.WriteLine("Choose a gender");
for (int i = 0; i < gender.Length; i++)
{
    Console.WriteLine(i+1 + " " + gender[i]);
}
selectedGender = int.Parse(Console.ReadLine()!);

Console.WriteLine(gender[selectedGender-1]);

void RollDice()
{
    Console.Clear();
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
    Console.Clear();
    Console.WriteLine("Roll dice for stammina!");
    Console.ReadKey();
    RollDice();
    Console.WriteLine("\n"+ dice);
    stammina = dice*7;
    Console.ReadKey();
}

void Strength()
{
    Console.Clear();
    Console.WriteLine("Roll dice for strength!");
    Console.ReadKey();
    RollDice();
    Console.WriteLine("\n"+ dice);
    strength = dice*4;
    Console.ReadKey();
}

void Charisma()
{
    Console.Clear();
    Console.WriteLine("Roll dice for charisma!");
    Console.ReadKey();
    RollDice();
    Console.WriteLine("\n"+ dice);
    charisma = dice*5;
    Console.ReadKey();
}


void Education()
{
    Console.Clear();
    Console.WriteLine("Roll dice for education!");
    Console.ReadKey();
    RollDice();
    Console.WriteLine("\n"+ dice);
    education = dice*7;
    Console.WriteLine("Education: " + education);
    Console.ReadKey();
}

void Intelligence()
{
    Console.Clear();
    Console.WriteLine("Roll dice for intelligence!");
    Console.ReadKey();
    RollDice();
    Console.WriteLine("\n"+ dice);
    intelligence = education/dice*11;
    Console.ReadKey();
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

Stammina();
Strength();
durability = stammina + strength / 4;
Charisma();
Education();
Intelligence();

Console.Clear();

Console.WriteLine("Name: " + name);
Console.WriteLine("Gender: " + gender[selectedGender-1]);
Console.WriteLine("Stammina " + stammina);
Console.WriteLine("Strength: " + strength);
Console.WriteLine("Durability: " + durability);
Console.WriteLine("Charisma " + charisma);
Console.WriteLine("Education: " + education);
Console.WriteLine("Intelligence: " + intelligence);

Console.WriteLine("Now lets change the values by rolling your age");
Age();

if (teen)
{
    stammina += 40;
    strength -= 10;
    durability = stammina + strength / 2;
    charisma -= 30;
    education -= 30;
    intelligence /= 2;
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
    Console.WriteLine("Adult");

}

else if (old)
{
    stammina /= 2;
    strength /= 2;
    durability = stammina - strength + 10;
    education -= 10;
    intelligence *= 2;
    Console.WriteLine("Old");

}


Console.WriteLine("Name: " + name);
Console.WriteLine("Gender: " + gender[selectedGender-1]);
Console.WriteLine("Age; " + age);
Console.WriteLine("Stammina " + stammina);
Console.WriteLine("Strength: " + strength);
Console.WriteLine("Durability: " + durability);
Console.WriteLine("Charisma " + charisma);
Console.WriteLine("Education: " + education);
Console.WriteLine("Intelligence: " + intelligence);




bool saveOption = false;


while (!saveOption)
{
    Console.WriteLine("Save [y/n]");
    string save = Console.ReadLine()!;
    
    if (save == "y" || save == "Y")
    {
        File.WriteAllText(path, "Name: " + name + "\nGender: " + gender[selectedGender-1] + "\nAge: " + age + "\nStammina: " + stammina + "\nStrength: " + strength + "\nDurability: " + durability + "\nCharisma: " + charisma + "\nEducation: " + education + "\nIntelligance: " + intelligence);
        saveOption = true;
        Console.ReadKey();
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