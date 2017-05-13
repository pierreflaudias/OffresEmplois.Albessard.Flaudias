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
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        
        public string Title { get; set; }
        
        public DateTime Date { get; set; }

    }

}
