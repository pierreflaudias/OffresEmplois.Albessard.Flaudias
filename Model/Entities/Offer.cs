using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Offer
    {
        /// <summary>
        /// The id of the offer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The label of the offer
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The date when the offer was posted
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The salary given by the offer
        /// </summary>
        public float Salary { get; set; }

        /// <summary>
        /// The description of the offer
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The id of the status
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// The status of the offer
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// The responsible of the offer
        /// </summary>
        public string Responsible { get; set; }

        /// <summary>
        /// The postulations for this offer
        /// </summary>
        public ICollection<Postulation> Postulations { get; set; }

    }
}
