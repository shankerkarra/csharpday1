using System;

namespace csharpday1.Models
{

  //  Create a constructor

  public class RockPaperScissor
  {
    public int playerScore = 0;
    public int computerScore = 0;
    public void displayResult()
    {
      Console.WriteLine("ComputerScore: :" + computerScore + " and PlayerScore: " + playerScore);
    }
    private int cRandom()
    {
      Random c = new Random();
      // Console.WriteLine("Random generated " + c.Next(1, 4));
      return c.Next(1, 4);
    }

    public void RPSGame(String userInput)
    {
      String inputCPU = "";
      int randomInt = cRandom();
      switch (randomInt)
      {
        case 1:
          inputCPU = "ROCK";
          Console.WriteLine("Computer chose ROCK");
          if (userInput == "ROCK")
          {
            Console.WriteLine("DRAW!!\n\n");
          }
          else if (userInput == "PAPER")
          {
            Console.WriteLine("PLAYER WINS!!\n\n");
            playerScore++;
          }
          else if (userInput == "SCISSORS")
          {
            Console.WriteLine("CPU WINS!!\n\n");
            computerScore++;
          }
          break;
        case 2:
          inputCPU = "PAPER";
          Console.WriteLine("Computer chose PAPER");
          if (userInput == "PAPER")
          {
            Console.WriteLine("DRAW!!\n\n");
          }
          else if (userInput == "ROCK")
          {
            Console.WriteLine("CPU WINS!!\n\n");
            computerScore++;
          }
          else if (userInput == "SCISSORS")
          {
            Console.WriteLine("PLAYER WINS!!\n\n");
            playerScore++;
          }
          break;
        case 3:
          inputCPU = "SCISSORS";
          Console.WriteLine("Computer chose SCISSORS");
          if (userInput == "SCISSORS")
          {
            Console.WriteLine("DRAW!!\n\n");
          }
          else if (userInput == "ROCK")
          {
            Console.WriteLine("PLAYER WINS!!\n\n");
            playerScore++;
          }
          else if (userInput == "PAPER")
          {
            Console.WriteLine("CPU WINS!!\n\n");
            computerScore++;
          }
          break;
        default:
          Console.WriteLine("Invalid entry!");
          break;
      }

    }
  }
}