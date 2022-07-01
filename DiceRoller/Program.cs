int result = 0;
bool runProgram = true;
Console.WriteLine("Welcome to the magical dice game");
Console.WriteLine("Enter the number of sides for a pair of dice ");
while (true)
{

    try
    {
        result = int.Parse(Console.ReadLine());
        if (result < 1)
        {
            throw new Exception("Number out of range");
        }
        else
        {
            //in a range and a number
            break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("You're playing this dice game. Enter a number or stay in this loop forever.");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
Console.WriteLine(result);
Console.WriteLine("Get ready to play! Take these pair of dices and see what you get!");
int dice1;
int dice2;
Random random = new Random();

while (runProgram)
{
    Console.WriteLine("Press any key to roll the dice.");
    Console.WriteLine();
    Console.ReadKey();

    if (result == 6)
    {
        dice1 = random.Next(1, result+1); //result 
        dice2 = random.Next(1, result+1); //result
        int dice3 = dice1 + dice2;
        Console.WriteLine("You rolled a " + dice1); //using this to see my number
        Console.WriteLine("You rolled a " + dice2); //using this to see my number
        Console.WriteLine("");

        string news = DiceSix(dice1, dice2); //if they are rolling a 6 sided die print this method output
        Console.WriteLine(news);
        Console.WriteLine($"You rolled a {dice1} and a {dice2} ({dice3} Total)");
        Console.WriteLine();
    }

     /* if (result ==69)
    {
        dice1 = random.Next(1, result + 1); //result 
        dice2 = random.Next(1, result + 1); //result
        int dice3 = dice1 + dice2;
        Console.WriteLine("You rolled a " + dice1); //using this to see my number
        Console.WriteLine("You rolled a " + dice2); //using this to see my number
        Console.WriteLine("");

        string news = FunnyNumber(dice1, dice2); //if they are rolling a 6 sided die print this method output
        Console.WriteLine(news);
        Console.WriteLine($"You rolled a {dice1} and a {dice2} ({dice3} Total)");
        Console.WriteLine();

    } */

    else
    {
        dice1 = random.Next(1, result+1); //result 
        dice2 = random.Next(1, result+1); //result
        int dice3 = dice1 + dice2;
        Console.WriteLine("You rolled a " + dice1); //using this to see my number
        Console.WriteLine("You rolled a " + dice2); //using this to see my number
        Console.WriteLine("");
        Console.WriteLine($"You rolled a {dice1} and a {dice2} ({dice3} Total)");
        Console.WriteLine();
    }
    while (true)
    {
        Console.WriteLine("Roll again? (y/n)");
        string playAgain = Console.ReadLine().ToLower().Trim();
        if (playAgain == "y")
        {
            break;
        }
        else if (playAgain == "n")
        {
            Console.WriteLine("Come back again friend!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Sorry, you entered a bad input.");
            continue;
        }
    }


}

static string DiceSix(double x, double y) 
{
    string message;

    if (x == 6 && y == 6)
    {
        message = "Box Cars! You got Two 6s \nCraps!";
    }
    else if (x == 1 && y == 1)
    {
        message = "Snake Eyes! You got Two 1s \nCraps!"; //do the same thing 56
    }
    else if (x + y == 3)
    {
        message = "Ace Deuce! You got a 1 and 2! \nCraps!"; //do the same thing 56
    }
    else if (x + y == 7 || x + y == 11)
    {
        message = "Win!";
    }
    else
    {
        message = "No snake eyes or anything"; //do the same thing 56
    }
    return message;
}


static string FunnyNumber(double x, double y)
{
    string message;

    if (x == 69 && y == 69)
    {
        message = "Magical number!!!";
    }
    else if (x + y == 69)
    {
        message = "Winner Winner Chicken Dinner!";
    }
    else
    {
        message = "Nothing special"; //do the same thing 56
    }
    return message;
}


//string message;
//message = "Box Cars\nCraps!"
//Console.WriteLine(message)'


static bool GoAgain()
{
    while (true)
    {
        Console.WriteLine("Do you want to go again(y/n)?");
        string input = Console.ReadLine();
        try
        {
            if (input.ToLower().Trim() == "y")
            {
                return true;
            }
            else if (input.ToLower().Trim() == "n")
            {
                return false;
            }
            else
            {
                throw new Exception("Not a valid option, please try again.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

//Console.WriteLine(GoAgain()); Couldnt figure out how to place this method in my code :(





/*
if (result == 6)
{
    dice1 = random.Next(1, result); //result 
    dice2 = random.Next(1, result); //result
    int dice3 = dice1 + dice2;
    Console.WriteLine("You rolled a " + dice1); //using this to see my number
    Console.WriteLine("You rolled a " + dice2); //using this to see my number
    Console.WriteLine("");

    string news = FirstDice(dice1, dice2); //if they are rolling a 6 sided die print this method output
    Console.WriteLine(news);
    Console.WriteLine($"You rolled a {dice1} and a {dice2} ({dice3} Total)");
    Console.WriteLine();
} 
*/

/*
while (true)
{
    Console.WriteLine("Press any key to roll the dice.");
    Console.WriteLine();
    Console.ReadKey();

    dice1 = random.Next(1, result); //result 
    dice2 = random.Next(1, result); //result
    int dice3 = dice1 + dice2;
    Console.WriteLine("You rolled a " + dice1); //using this to see my number
    Console.WriteLine("You rolled a " + dice2); //using this to see my number
    Console.WriteLine("");

    string news = FirstDice(dice1, dice2); //if they are rolling a 6 sided die print this method output
    Console.WriteLine(news);
    Console.WriteLine($"You rolled a {dice1} and a {dice2} ({dice3} Total)");
    Console.WriteLine();
} */