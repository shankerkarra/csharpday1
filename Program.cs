using System;
using csharpday1.Models;

namespace csharpday1
{

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      bool gamePlay = true;
      //   int playerScore = 0;
      //   int computerScore = 0;

      while (gamePlay)
      {
        Console.WriteLine("Do you choose Rock, Paper or Scissors");
        String userEntered = Console.ReadLine().ToUpper();
        // Console.WriteLine($"User Entered Choice is: {userEntered}");
        if (userEntered != "rock" || userEntered != "paper" || userEntered != "scissors")
        {
          Console.WriteLine($"User Entered Choice is: {userEntered}");
          RockPaperScissor Rps = new RockPaperScissor();
          Rps.displayResult();
          Rps.RPSGame(userEntered);
          Rps.displayResult();
          //   Console.WriteLine("ComputerScore: :" + computerScore + "and PlayerScore: " + playerScore);
        }
      }
    }
  }
}
