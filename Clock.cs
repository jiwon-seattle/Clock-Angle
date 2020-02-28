using System;
using System.Collections.Generic;

class Clock {

    public static Dictionary<int, int> time = new Dictionary<int, int>() {};

    static void Main()
    {
      time.Add(12, 0);
      time.Add(1, 30);
      time.Add(2, 60);
      time.Add(3, 90);
      time.Add(4, 120);
      time.Add(5, 150);
      time.Add(6, 180);
      time.Add(7, 210);
      time.Add(8, 240);
      time.Add(9, 270);
      time.Add(10, 300);
      time.Add(11, 330);

    CheckInput();

    }

    static void CheckInput()
    {
      Console.WriteLine("Enter a clock that you want to check degrees. Format would be [TIMEMINUTE: 1230, 0459].");
      string userInput = Console.ReadLine();
      int userInputHour = (int)char.GetNumericValue(userInput[0]);
      int userInputMinute = (int)char.GetNumericValue(userInput[2]);
      int userInputOnetoNine = int.Parse(userInput.Substring(1,1));
      int userInputTentoEleven = int.Parse(userInput.Substring(0, 2));



      if (userInputTentoEleven == 12 && userInputMinute >= 3)
      {
        Console.WriteLine(time[1]);
      }
      else if (userInputTentoEleven == 12 && userInputMinute < 3)
      {
        Console.WriteLine(time[12]);
      }
      else if (userInputHour == 0 && userInputMinute >= 3)
      {
        Console.WriteLine(time[userInputOnetoNine + 1]);
      }
      else if (userInputHour == 0 && userInputMinute < 3)
      {
        Console.WriteLine(time[userInputOnetoNine]);
      }
      else if (userInputHour == 1 && userInputMinute >= 3)
      {
        Console.WriteLine(time[userInputTentoEleven + 1]);
      }
      else if (userInputHour == 1 && userInputMinute < 3)
      {
        Console.WriteLine(time[userInputTentoEleven]);
      }

    }
}
