using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CabCompany;
using System.Threading;
namespace UInterface
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
         
            Cab cab = new Cab("LeCab");
            bool iSnew = false;
            string inputLine=string.Empty;
            double money;
            decimal distance;
            string day="day";
            string car="car";
            string additionalInfo;
            Console.WriteLine("Hello!Thank you for choosing our LeCab");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string log = @"                                                                               
      `-//+++++++++++++/:.                                                                          
     .+++//:::::::::::/+++/`           ...`                      `...`                 ...          
    `+++-`             `/++/          `yyy/                  `-+ssyyyss+-             .yyy.         
    /++/                `+++-         `yyy/     .-:/::.`    .oyys+:--/os:  `.-://:-.  .yyy-.:::.`   
  ./+++`                 .+++:`       `yyy/   .osysoosys-   syys.     ``  .sysoooyyy+ .yyyssssyys/  
 -+++:`   ``         ``   ./+++.      `yyy/  .syy:` `.syy- .yyy/           -.```.:yyy..yyy/```-yyy: 
 :+++`   -++//::::://+/.   -+++-      `yyy/  /yyyooooosyy+ .yyy/           ./oooosyyy..yyy.    oyys 
 `/+++-  `://++++++///-`  :+++:       `yyy/  /yyy////////-  syys`         +yyo-..-yyy..yyy.    oyyo 
   /++-    ``````````     /++:        `yyyo..`syy/.```.:`   .syys:...-/+-`yyy:  `-yyy-.yyy/```-yyy- 
   /++/`  `///::::://:`  `+++-         syyyyy `+syysssys+    `/ssyyyyyys/`/syyooosoys:.yysososyys:  
   `/++///++++++++++++///+++/          `-----   `.----.`        .-----.`   `----.``-. `--.`.---.    
    `-//++/:.```````-//++/:.                                                                        
        ``             `                                                                   ";
            Console.WriteLine(log);
            Console.ResetColor();
            while (true)
          {
                Console.WriteLine("\nPress the Escape (Esc) key to quit: ");
                Console.WriteLine("Press the Backspace to restart: ");
                Console.WriteLine("Press 'Enter' to start your jorney :) ");
                Console.WriteLine("Press 'Q' to clear the console");
                Client client = new Client();
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Y) Console.Clear();
                if (cki.Key == ConsoleKey.Escape) break;
                if (cki.Key == ConsoleKey.Backspace) continue;
                if (cki.Key == ConsoleKey.Q) Console.Clear();
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Input your name:");
                    inputLine = Console.ReadLine();
                    client.Name = inputLine;

                    Console.WriteLine("Press Y/y if you're a registered client,otherwise press N/n");
                    while (true)
                    {
                        inputLine = Console.ReadLine();
                        if (inputLine.ToUpper() == "N") { iSnew = false; break; }
                        else if (inputLine.ToUpper() == "Y") { iSnew = true; break; }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Oops,it seems that you enter something strange");
                        Console.ResetColor();
                    }
                    client.IsRegistered = iSnew;
                    Console.WriteLine("Then you can put your money on your card");
                    Console.WriteLine("Enter the amount of money:");
                    while (true)
                    {
                        inputLine = Console.ReadLine();
                        if ((double.TryParse(inputLine, out money))&& money >100)
                        {
                            money = Convert.ToDouble(inputLine);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You enter an inappropriate data or you put money less than 100 UAH.Try again");
                        Console.ResetColor();
                    }
                    client.Money = money;
                }
               else continue;
                Console.WriteLine("Press 'K' to specify more some details");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.K)
                {
                    Console.WriteLine("\nInput a distance:");
                    while (true)
                    {
                        inputLine = Console.ReadLine();
                        if ((decimal.TryParse(inputLine, out distance))&& distance>500)
                        {
                            distance = Convert.ToDecimal(inputLine);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You enter inappropriate data.Try again");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Input a day:");
                    while (true) {
                        inputLine = Console.ReadLine();
                        inputLine = inputLine.Substring(0, inputLine.Length).Replace(inputLine.ElementAt(0), Char.ToUpper(inputLine.ElementAt(0)));
                        if (inputLine == "Monday" || inputLine == "Tuesday" || inputLine == "Wednesday" || inputLine == "Thursday" || inputLine == "Friday" || inputLine == "Saturday" || inputLine == "Sunday")
                        {
                            day = inputLine;
                            break;
                        }
                            Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("Enter the day of the week.Try again");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Then you have to choose a car.Press any number from 1-5:");
                    while (true)
                    {
                        int i = 0;
                        try
                        {
                            i = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a number");
                            Console.ResetColor();
                        }
                        if (i >= 2 && i <= 5)
                        {
                            switch (i)
                            {
                                case 1:
                                    car = "Acura";
                                    break;
                                case 2:
                                    car = "Bugatti";
                                    break;
                                case 3:
                                    car = "Honda";
                                    break;
                                case 4:
                                    car = "Ford";
                                    break;
                                case 5:
                                    car = "Mercedes-Benz";
                                    break;

                            }
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You enter inappropriate data.Try again");
                        Console.ResetColor();
                    }
                    Console.WriteLine("And finally,where did you find us?");
                    additionalInfo = Console.ReadLine();
                    Console.WriteLine("information is processed....");
                    Thread.Sleep(2000);
                    client.ChooseTrip(distance, day, car, additionalInfo);
                    cab.ServeAClient(client);
                    cab.getInfoWorkers();
                    Console.WriteLine();
                    cab.getClientsId();
                }
                else continue;
                
            }
           

        }

       
    }    
 }
    

