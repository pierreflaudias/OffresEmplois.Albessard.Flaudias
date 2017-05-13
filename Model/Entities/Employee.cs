using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Seniority { get; set; }

        public string Biography { get; set; }

        public ICollection<Experience> Experiences { get; set; }
    }
}
