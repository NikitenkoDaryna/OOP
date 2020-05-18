using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabCompany
{
    public abstract class ClientBase
    {
        public string Name { get; set; } = "default_name";
        public bool IsRegistered { get; set; }
        public double Money {
            get;set; }
        public int Id { get; set; }
        public ClientBase(string name, bool isRegistered,double money)
        {
            Name = name;
            IsRegistered = isRegistered;
            Money = money;
        }
      public ClientBase()
        {

        }

        public abstract void ChooseTrip(decimal distance, string day, string transport, string extraInformation);
        public abstract void Pay();
        public override string ToString()
        {
            return string.Format("Name: {0}, Id: {1}", Name, Id);
        }
    }
}
