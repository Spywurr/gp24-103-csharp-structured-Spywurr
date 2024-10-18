using System;

internal class Program
{
    // I created a function to only accept valid inputs, with 3 calls to simplify the rest of the code
    // If you enter a number too high/low it will keep asking for a number within min/max
    // Since the game only accepts numbers I didnt either allow strings, only ints
    private static int ValidInput(string input, int min, int max)
    {
        Console.WriteLine(input);
        int userInput;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput >= min && userInput <= max)
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine($"You need to enter a number between {min} and {max}.");
                }
            }
            else
            {
                Console.WriteLine($"You need to enter a number between {min} and {max}.");
            }
        }
    }
    //Then I created a function to remove all Zeros from the array once a index was emptied
    //It takes in the array with zeros and returns the array without zeros and empty indices


    private static int[] RemoveZeroIndex(int[] array)
    {
        int hasValueCounter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                hasValueCounter++;
            }
        }

        int[] result = new int[hasValueCounter];
        int index = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] != 0)
            {
                result[index] = array[j];
                index++;
            }
        }
        return result;
    }

    // This nested for loop took me a long time to get right, there was no good guide that I could find that
    // would print two characters on top of each other, but its just the nested for loop twice with O or |
    private static void PrintGame(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int rows = array[i];
            for (int j = 0; j < rows; j++)
            {
                Console.Write("O ");
            }
            Console.Write($"| Stack #{i + 1}. Remaining matches: {array[i]}");
            Console.WriteLine();

            for (int j = 0; j < rows; j++)
            {
                Console.Write("| ");
            }
            Console.WriteLine();
        }
    }

    // This is the part where the user gets to type in how many matches to remove from the stacks
    // The code on the second line gets extremely long, but I'm not sure how to shorten it
    // But it works
    // If the player removes the last match from a list we call RemoveZeroIndex and make a new array
    private static int[] PlayerTurn(int[] array)
    {
        int stackRemovalChoice = ValidInput($"Which stack would you like to remove from? (1-{array.Length})", 1, array.Length) - 1;
        int howManyMatchesToRemove = ValidInput($"How many matches would you like to remove from stack #{stackRemovalChoice + 1}? (1-{Math.Min(array[stackRemovalChoice], 3)})", 1, Math.Min(array[stackRemovalChoice], 3));


        array[stackRemovalChoice] -= howManyMatchesToRemove;


        if (array[stackRemovalChoice] <= 0)
        {
            array = RemoveZeroIndex(array);
        }

        return array;
    }

    // This is the least impressive part of the code, its literally just a random number generator for the AI
    // Same as PlayerTurn we make a new array if it gets emptied out
    private static int[] AiTurn(int[] array)
    {
        Random random = new Random();

        int aiStackChoice = random.Next(array.Length);


        int aiMatchChoice = Math.Min(random.Next(1, Math.Min(array[aiStackChoice], 4)), array[aiStackChoice]);


        array[aiStackChoice] -= aiMatchChoice;
        Console.WriteLine($"AI has chosen to remove {aiMatchChoice} from stack #{aiStackChoice + 1}");


        if (array[aiStackChoice] <= 0)
        {
            array = RemoveZeroIndex(array);
        }

        return array;
    }

    // The main part gets a bit messy, I could probably have made a function to initialize the game
    // (Choose stacks and populate the stacks)
    // I'm calling ValidInput to check for valid inputs from the user
    private static void Main(string[] args)
    {
        int minStacks = 3;
        int maxStacks = 5;
        int minMatches = 3;
        int maxMatches = 6;

        int howManyStacks = ValidInput($"How many stacks do you want to play? ({minStacks}-{maxStacks} Allowed)", minStacks, maxStacks);
        int[] matchList = new int[howManyStacks];


        for (int stackNumber = 0; stackNumber < howManyStacks; stackNumber++)
        {
            int howManyMatches = ValidInput($"How many matches do you want to add to stack #{stackNumber + 1}? ({minMatches}-{maxMatches} Allowed)", minMatches, maxMatches);
            matchList[stackNumber] = howManyMatches;
        }

        // This next part is the main game loop where we switch between player/!player turn
        // The entire game is just a manipulation of the list you made from the start
        // Every function except the printing/validinput function takes in the list and
        // Spits out a new version with alterations
        // If the list gets empty the game is over, depending on whos turn it is

        bool isPlayerTurn = true;
        while (matchList.Length > 0)
        {
            PrintGame(matchList);
            if (isPlayerTurn)
            {
                matchList = PlayerTurn(matchList);
            }
            else
            {
                matchList = AiTurn(matchList);
            }


            isPlayerTurn = !isPlayerTurn;
        }


        if (isPlayerTurn)
        {
            Console.WriteLine("Player wins! All stacks are empty. Game over!");
        }
        else
        {
            Console.WriteLine("AI wins! All stacks are empty. Game over!");
        }
    }
}