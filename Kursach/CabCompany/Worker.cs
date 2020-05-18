using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabCompany
{
    
    public class Worker : WorkerBase
    {
        
        public Worker(string name, string startWorkingTime, string endWorkingTime, decimal hourlyRate) : base(name, startWorkingTime, endWorkingTime, hourlyRate)
        {
            CalculateSalary();
        }
        protected override sealed decimal CalculateSalary()
        {
            TimeSpan duration = DateTime.Parse(EndWorkingTime).Subtract(DateTime.Parse(StartWorkingTime));
            Salary+= Convert.ToDecimal(duration.TotalHours)*HourlyRate;
            return Salary;
        }

        public Worker():base()
        {

        }
    }
}
