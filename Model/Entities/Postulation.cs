using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Postulation
    {

        /// <summary>
        /// The id of the offer in the postulation
        /// </summary>
        public int OfferId { get; set; }

        /// <summary>
        /// The offer in the postulation
        /// </summary>
        public Offer Offer { get; set; }

        /// <summary>
        /// The id of the employee in the postulation
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// The employee in the postulation
        /// </summary>
        public Employee Employee {get; set;}

        /// <summary>
        /// The date of the postulation
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The status of the postulation
        /// </summary>
        public string Status { get; set; }

    }
}
