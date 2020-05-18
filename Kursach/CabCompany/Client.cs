using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabCompany
{
    public delegate void MyEventHandler();
    public class Client : ClientBase
    {
        public event MyEventHandler SomethingHappened;
        public Trip trip = new Trip();
        public event Action Notify;
        public Client(string name, bool isRegistered,double money) : base(name, isRegistered,money)
        {
           if(isRegistered)trip.Price-=trip.Price*0.15;
        }
        public Client() : base()
        {

        }

        protected virtual void OnProcessCompleted() 
        {
            Console.WriteLine($"The order came from {Name} ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (IsRegistered) Console.WriteLine($" {Name} you are a registered client,so we've prepared you a special 15% discount :)");
            Notify?.Invoke();
            Console.ResetColor();
        }
        public override void ChooseTrip(decimal distance, string day, string car, string extraInformation)
        {
            trip.Distance = distance;
            trip.Day = day;
            trip.Car = car;
            trip.ExtraInformation = extraInformation;
            OnProcessCompleted();
            if (!trip.trips.Contains(trip))
            {
                trip.trips.Add(trip);
            }

            foreach (Trip trip in trip.trips)
            {
                trip.PrintInfo();
            }
            
        }
        public override void Pay()
        {
            
            if (Money >= trip.Price)
            {
                Money -= trip.Price;
                SomethingHappened += Client_SomethingHappened;
                SomethingHappened?.Invoke();
               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name},you dont't have enough money");
                Console.ResetColor();
            }
           
        }

        private void Client_SomethingHappened()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Name},you paid {trip.Price}.Now you have {Money}");
            Console.ResetColor();
        }
    }
}
