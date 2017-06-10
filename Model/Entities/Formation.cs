using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Formation
    {
        /// <summary>
        /// The id of the formation
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The id of the employee in the formation
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// The title of the formation
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The date of the formation
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The employee in the formation
        /// </summary>
        public Employee Employee { get; set; }


    }
}
