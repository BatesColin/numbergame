using System;
class NumCheck
{


  static void Main(){

    Console.WriteLine("Would you like to play the higher/lower game (y/n)?");
    string game = Console.ReadLine();
    string output = "is your guess higher or lower than";
    int check = 50;
  
    if(game == "y")
    {
      Console.WriteLine("is your number 50?")
      Console.WriteLine("if correct type correct, otherwise say higher, or lower");

      string guess = " "
      while(guess != "correct")
      {
        guess = Console.ReadLine();

        int modifier =check/2;

        if (guess == "higher")

        {

          check=check+modifier;
          Console.WriteLine(output+ check);
        }
        else if (guess == "lower")
        {

          check = check -modifier;
          Console.WriteLine(output + check);
        }
        else
        {
          check= check/2;
          Console.WriteLine(output+ check);
        }

      }
    }
      else
      {
        Console.WriteLine("sad");
      }

    }
  }



// for(i=0; i <7; i++)
// {
