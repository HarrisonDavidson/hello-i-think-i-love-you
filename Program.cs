// I have no idea why I need this. I assume it's something like an import of a library? 

using System;

// This gives the computer a list of things to do.

// These are functions which tells the computer what to do.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Hello. I Think I Love You.");
Console.WriteLine("A game by Harrison Davidson");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// This continues the list of functions, but tells the computer to read ahead at each item for detailed instructions.

MooseSays("H E L L O.  I  T H I N K  I  L O V E  Y O U.");

AskQuestion("Do you love me?", "Really? It seems very unlikely.", "I KNEW IT !!!");
AskQuestion("Do you hate me?", "Yay!", "You should try it!");
AskQuestion("Are you afraid of me?", "Don't be scared, dear.", "You will be...oh, yes, you will be...");
AskQuestion("Do you want to know a secret?", "I love secrets...", "Secrets are the best, I love to share them!");



// This tells the computer how to do those things listed above.

void MooseSays(string message)
{
    Console.WriteLine($@"

    For the best experience please adjust your window to display only the line above and the question at the bottom...

⢿⣿⣿⣿⣭⠹⠛⠛⠛⢿⣿⣿⣿⣿⡿⣿⠷⠶⠿⢻⣿⣛⣦⣙⠻⣿
⣿⣿⢿⣿⠏⠀⠀⡀⠀⠈⣿⢛⣽⣜⠯⣽⠀⠀⠀⠀⠙⢿⣷⣻⡀⢿
⠐⠛⢿⣾⣖⣤⡀⠀⢀⡰⠿⢷⣶⣿⡇⠻⣖⣒⣒⣶⣿⣿⡟⢙⣶⣮
⣤⠀⠀⠛⠻⠗⠿⠿⣯⡆⣿⣛⣿⡿⠿⠮⡶⠼⠟⠙⠊⠁⠀⠸⢣⣿
⣿⣷⡀⠀⠀⠀⠀⠠⠭⣍⡉⢩⣥⡤⠥⣤⡶⣒⠀⠀⠀⠀⠀⢰⣿⣿
⣿⣿⡽⡄⠀⠀⠀⢿⣿⣆⣿⣧⢡⣾⣿⡇⣾⣿⡇⠀⠀⠀⠀⣿⡇⠃ {message}
⣿⣿⣷⣻⣆⢄⠀⠈⠉⠉⠛⠛⠘⠛⠛⠛⠙⠛⠁⠀⠀⠀⠀⣿⡇⢸
⢞⣿⣿⣷⣝⣷⣝⠦⡀⠀⠀⠀⠀⠀⠀⠀⡀⢀⠀⠀⠀⠀⠀⠛⣿⠈
⣦⡑⠛⣟⢿⡿⣿⣷⣝⢧⡀⠀⠀⣶⣸⡇⣿⢸⣧⠀⠀⠀⠀⢸⡿⡆
⣿⣿⣷⣮⣭⣍⡛⠻⢿⣷⠿⣶⣶⣬⣬⣁⣉⣀⣀⣁⡤⢴⣺⣾⣽⡇


 ");
}

void AskQuestion(string question, string yesResponse, string noResponse) // we're passing in 3 strings, question, yesResponse, and noResponse
{
    bool isTrue = MooseAsks(question); //if the answer is yes, isTrue will be true, if the answer is no, isTrue will be false
    // if (isTrue)
    // {
    //     MooseSays(yesResponse);
    // }
    // else
    // {
    //     MooseSays(noResponse);
    // }

    string response = isTrue ? yesResponse : noResponse ;

    MooseSays(response);
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}