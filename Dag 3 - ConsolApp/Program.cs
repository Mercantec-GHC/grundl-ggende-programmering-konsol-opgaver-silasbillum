/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
*/
/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/
/*
int saleAmount = 1001;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/
/*
Random flip = new Random();
int num = flip.Next(2);
if (num == 0)
{
    Console.WriteLine("Heads");
}
else if (num == 1)
{
    Console.WriteLine("Tails");
}
Console.WriteLine(num);
*/
/*
string permission = "Admin||Manager";
int level = 20;

if(level >= 55 && permission.Contains("Admin"))
{
    Console.WriteLine( "Welcome, Super Admin user.");
}
else if (level <= 55 && permission.Contains("Admin"))
{
    Console.WriteLine( "Welcome, Admin user.");
}
else if (level >= 20 && permission.Contains("Manager"))
{
    Console.WriteLine( "Contact an Admin for access.");
}
else if (level < 20 && permission.Contains("Manager"))
{
    Console.WriteLine( "You do not have sufficient privileges.");
}
else if ( !permission.Contains("Admin" + "Manager"))
{
    Console.WriteLine( "You do not have sufficient privileges.");
}
*/
/*
bool flag = true;
int value =0;
if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");
*/
/*
bool flag = true;
if (flag) Console.WriteLine(flag);
*/
/*
string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob");

else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");
*/
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = true;
int total=0;
foreach (int number in numbers)
{
     

    total += number;

    if (number == 42)
    {
        found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/
/*
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    
    
    case 200:
    title = "Senior Associate";
    break;
    case 300:
    title = " Manager";
    break;
    case 400:
    title = "Senior Manager";
    break;
    default:
    title = "Associate";
    break;
}
Console.WriteLine($"{employeeName}, {title}");
*/
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/*
using System.Drawing;

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
    type = "Sweat shirt";
    break;

    case "02":
    type = "T-shirt";
    break;

    case "03":
    type = "Sweat pants";
    break;

}
switch(product[1])
{
    case "BL":
    color = "Black";
    break;

    case "MN":
    color = "Maroon";
    break;
}

switch(product[2])
{
    case "S":
    size = "small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size = "Large";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
*/
/*
using System.Reflection.Metadata;

string[] names = { "Ales", "Eddie", "David", "Michael"};
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)

    {if (names[i] == "David") names[i] = "Sammy";}
    
    foreach (var name in names)
    { Console.WriteLine(name);}
    */


/*
   for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine(i + " FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine(i + " Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine(i + " Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
    */
/*
        Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);
  */
/*
while (current >= 3)
{
  Console.WriteLine(current);
  current = random.Next(1, 11);

}  
Console.WriteLine($"Last number: {current}    " );
  */
/*
int hero = 10;
    int monster = 10;
    Random random = new Random();

    do
    {
        int hit = random.Next(1, 10);


        monster -= hit;
        Console.WriteLine("Hero hits the monster for " + hit + " damage. Monster's HP: " + monster);


        if (monster <= 0)
        {
            Console.WriteLine("Hero defeats the monster!");
            break;
        }


        hit = random.Next(1, 10);
        hero -= hit;
        Console.WriteLine("Monster hits the hero for " + hit + " damage. Hero's HP: " + hero);


        if (hero <= 0)
        {
            Console.WriteLine("Monster defeats the hero!");
            break;
        }

    } while (hero > 0 && monster > 0);
    */
/*
        string? readResult;
        bool validEntry = false;
        Console.WriteLine("Enter a string containing at least three characters:");
        do{
            readResult = Console.ReadLine();
    if (readResult != null)
    if (readResult.Length >= 3)
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine("Your input is invalid, please try again.");
    }
        }while (validEntry == false);
        

        int numberValue = 0;
        bool validNumber = false;

        validNumber = int.TryParse(readResult, out numberValue);
        */
/*

string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
readResult = Console.ReadLine();
if (readResult != null) 
{
valueEntered = readResult;
}

validNumber = int.TryParse(valueEntered, out numValue);

if (validNumber == true)
{
if (numValue <= 5 || numValue >= 10)
{
    validNumber = false;
    Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
} 
}
else 
{
Console.WriteLine("Sorry, you entered an invalid number, please try again");
}
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/
/*
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/

// the ourAnimals array will store the following: 

using System.Collections;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)

    switch (i)
    {
        case 0:
          animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
        break;

        case 1:
         animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
        break;

        case 2:
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
        break;

        case 3:
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;

        case 4:
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;

        case 5:
        ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    break;
    
     default:
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;

    
}
do{
    readResult = Console.ReadLine();
}while (menuSelection != "exit");
// display the top-level menu options



Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");

// pause code execution
readResult = Console.ReadLine();

/*
switch(menuSelection)
{
    case "1":
     Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
    break;
     case "2":
      Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "3":
        break;

    case "4":
        break;

    case "5":
        break;

    case "6":
        break;

    case "7":
        break;

    case "8":
        break;

    default:
    break;
}
*/
/*
for (int i = 0; i < maxPets; i++)
{
    string[][] jaggedArray = new string[][]
{
    new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
    new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
    new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
    new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
    new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
    new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
    new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
    new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
    
};
for (int i = 0; i < maxPets; i++)
{
    if (ourAnimals[i, 0] != "ID #: ")
    {
        Console.WriteLine(ourAnimals[i, 0]);
    }
}
foreach (string[] array in jaggedArray)
{
    foreach (string value in array)
    {
        Console.WriteLine(value);
    }
    Console.WriteLine();
}

}

*/
