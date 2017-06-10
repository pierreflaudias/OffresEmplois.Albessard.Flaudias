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
        /// <summary>
        /// The id of the employee
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the employee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The firstname of the employee
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The birthdate of the employee
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The seniority of the employee (how many years in the enterprise
        /// </summary>
        public int Seniority { get; set; }

        /// <summary>
        /// The biography of the employee
        /// </summary>
        public string Biography { get; set; }

        /// <summary>
        /// The experiences of the employee
        /// </summary>
        public ICollection<Experience> Experiences { get; set; }

        /// <summary>
        /// The formations of the employee
        /// </summary>
        public ICollection<Formation> Formations { get; set; }

        /// <summary>
        /// The postulations of the employee
        /// </summary>
        public ICollection<Postulation> Postulations { get; set; }

    }
}
