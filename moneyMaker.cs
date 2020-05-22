using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
        // User enters the variables into the
      Console.WriteLine("How money would you like to convert?");
      string userMoney = Console.ReadLine();
        // Converts input into Double
      double userMoneyDouble = Convert.ToDouble(userMoney);
      double Gold = .1;
      double Silver = .05;
      double Bronze = .01;
      double goldRemainder = (userMoneyDouble%Gold);
        // Number of Gold coins
      double goldValue = Math.Floor(userMoneyDouble/Gold);
      double silverRemainder = (goldRemainder%Silver);
        // Number of Silver Coins
      double silverValue =
      Math.Floor(goldRemainder/Silver);
      double bronzeValue = Math.Ceiling(silverRemainder/Bronze);

      Console.WriteLine($"The Smallest amount of coins will be... \n Gold Coins: {goldValue} \n Silver Coins: {silverValue} \n Bronze Coins: {bronzeValue}");


    }
  }
}
