using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CabCompany
{
    public class Trip
    {
       public  delegate void getInfoSpecialDay();
       public  event getInfoSpecialDay InfoDay;
        readonly public List<Trip> trips = new List<Trip>();
        public decimal Distance {
            get;set;
        }
        public string ExtraInformation { get; set; }
        public double Price { get; set; } = 100;
        public string Day { get;  set; }
        public string Car { get;  set; }

        public Trip(decimal distance,string day,string car,string extraInformation)
        {
            Distance = distance;
            Day = day;
            Car = car;
            ExtraInformation = extraInformation; 
        }
        public Trip()
        {

        }
         public void PrintInfo()
        {
            CalcPrice();
            Console.WriteLine($"Distance:{Distance},Your price is:{Price},Your car is {Car},Day:{Day}");
            Console.WriteLine($"Where did you find us? {ExtraInformation}");
        }
        public void CalcPrice()
        {
            if (Distance > 1000)
                Price += 100d;
            if (Day == "Saturday" || Day == "Sunday")
            {
                Price += Price * 0.5;
                InfoDay += delegate
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Oops ?that's a weekend.The price has increased by 50%");
                    Console.ResetColor();
                };
                InfoDay?.Invoke();
                
            }
            if (Day == "Monday")
            {
                InfoDay += delegate
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Today is Monday.You get a 30% discount");
                    Console.ResetColor();
                };
                InfoDay?.Invoke();
                Price -= Price * 0.3; 
            }
            
        }
        

    }
}
