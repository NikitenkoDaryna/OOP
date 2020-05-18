using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CabCompany
{
    
    public class Cab
    {
        readonly List<Worker> workers = new List<Worker>();
        readonly List<Client> clients = new List<Client>();
        public string Name { get; set; }

        public Cab(string name)
        {
            Name = name;
            workers = new List<Worker>
            {
                new Worker("Andreo","7:00 AM","8:00 PM",7.1m),
                new Worker("Pavel","7:00 AM","6:00 PM",11.3m),
                new Worker("David","5:00 AM","3:00 PM",14.2m),
                new Worker("Oliver","6:00 AM","7:00 PM",7.67m),
                new Worker("Jacob","6:30 AM","5:00 PM",8.65m),
                new Worker("Gabriel","8:30 AM","7:00 PM",8.93m),
                new Worker("Ethan","7:30 AM","9:30 PM",9.23m)
            }; 
        }
        public void ServeAClient(Client client)
            
        {
            Console.WriteLine($"{client.Name},please wait for 2-5 minutes ...");
            Thread.Sleep(2000);
            client.Pay();
            client.Id = GetHashCode(client.Name);
             clients.Add(client);
        }  
        public void getClientsId()
        {
            Console.WriteLine("List of clients:");
            foreach (var cl in clients)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(cl);
                Console.ResetColor();
            }
        }
        public void getInfoWorkers()
        {
            Console.WriteLine("List of workers:");
            workers.Sort();
            foreach (var w in workers)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(w);
                Console.ResetColor();
            }
        }

        private static int GetHashCode(string value)
        {
            int h = 0;
            for (int i = 0; i < value.Length; i++)
                h += value[i] * 31 ^ value.Length - (i + 1);
            return h;
        }


    }
}
