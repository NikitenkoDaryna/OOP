using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabCompany
{
   public abstract class WorkerBase : IComparable<WorkerBase>
    {
        public string Name { get; set; }
        public decimal Salary { get;  set; }
        public decimal HourlyRate { get;  set; }
        public string StartWorkingTime { get;  set; }
        public string EndWorkingTime { get;  set; }
        public WorkerBase(string name,string startWorkingTime,string endWorkingTime,decimal hourlyRate)
        {
            Name = name;
            StartWorkingTime = startWorkingTime;
            EndWorkingTime = endWorkingTime;
            HourlyRate = hourlyRate;
        }
        protected abstract decimal CalculateSalary();
        public int CompareTo(WorkerBase other)
        {
            return -Salary.CompareTo(other.Salary);
        }
        public override string ToString()
        { 
            return string.Format("Name: {0},Working hours:{1} - {2}, Salary: {3}", Name, StartWorkingTime,EndWorkingTime,Salary); 
        }
        public WorkerBase()
        {

        }
     
       
       
        
    }
}
