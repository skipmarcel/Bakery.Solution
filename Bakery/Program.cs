using System;
using Bakery.Models;
using Bakery.UserInterfaceModels;


namespace Bakery
{
  class Program
  {
    static void Main()
    {
Console.WriteLine("                  ");
Console.WriteLine("             ~*** WELCOME TO ***~");
string welcomeBanner = WelcomeBanner.Welcome;
Console.WriteLine(welcomeBanner);

Console.WriteLine("                  ");
Console.WriteLine("Our bread loaves are $5 - Buy 2 get 1 free!");
Console.WriteLine("Our fruit pastries are $2 - Buy 3 get 1 free!");

Console.WriteLine("                  ");
Console.WriteLine("How many loaves of bread  would you like?");

string breadCount = Console.ReadLine();
int totalLoaves = int.Parse(breadCount);
BreadDeal deal = new BreadDeal(5.0m, totalLoaves);
decimal totalPrice = deal.GetTotalPrice();
Console.WriteLine($"Total for your bread: ${totalPrice:F2}");
Console.WriteLine("                  ");
Console.WriteLine("How many fruit pastries would you like?");

string pastryCount = Console.ReadLine();
int totalPastries = int.Parse(pastryCount);
PastryDeal pDeal = new PastryDeal(2.0m, totalPastries);
decimal totalPastryPrice = pDeal.GetTotalPastryPrice();
Console.WriteLine($"Total for your pastries: ${totalPastryPrice:F2}");
Console.WriteLine($"Your grand total is: ${totalPastryPrice + totalPrice:F2}");    
Console.WriteLine("Thank you for coming! Please tell a friend");     
    }

  }
}
