using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Postulation
    {

        public int OfferId { get; set; }
        
        public int EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }
    }
}
