using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Status
    {
        /// <summary>
        /// The id of the status
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// the label of the status
        /// </summary>
        [Required]
        public string Label { get; set; }
    }
}
