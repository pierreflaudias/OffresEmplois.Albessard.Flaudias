using Model.Entities;
using Model.FluentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextFluent context = new ContextFluent();
            context.Employees.ToList();
            Offer o = new Offer();
            o.Description = "testeteehjed";
            o.Salary = 3000000;
            o.Title = "testtt";
            o.Responsible = "ptgrprtg";
            o.Date = DateTime.Today;
            context.Offers.Add(o);
            //context.SaveChanges();
        }
    }
}
