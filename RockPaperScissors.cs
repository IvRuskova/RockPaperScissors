﻿const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();
if (playerMove == "r" || playerMove == "Rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "Paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "Scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}
Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = string.Empty;
if (computerRandomNumber ==1)
{
    computerMove = Paper;
}
else if (computerRandomNumber == 2)
{
    computerMove = Rock;
}
else if (computerRandomNumber == 3)
{
    computerMove = Scissors;
}
//else
//{
//    Console.WriteLine("Invalid Input. Try Again...");
//    return;
//}
Console.WriteLine($"The computer chose {computerMove}.");
if ((playerMove == Rock && computerMove == Scissors)||(playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper)) 
{
    Console.WriteLine("You win.");
}
else if ((playerMove == Rock && computerMove== Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("This game was a draw.");
}