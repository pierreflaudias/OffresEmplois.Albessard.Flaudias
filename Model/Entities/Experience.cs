using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Experience
    {
        /// <summary>
        /// The id of the experience
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The id of the employee in the experience
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// The employee in the experience
        /// </summary>
        public Employee Employee { get; set; }
        
        /// <summary>
        /// The title of the experience
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// The date of the experience
        /// </summary>
        public DateTime Date { get; set; }

    }

}
