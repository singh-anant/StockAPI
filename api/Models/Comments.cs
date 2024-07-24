using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comments
    {
        public int ID { get; set; }

        public string Title { get; set; }=string.Empty;

        public string Content { get; set; }=string.Empty;

        public DateTime CreatedOn { get; set; }=DateTime.Now;


//The ? after int makes it nullable, meaning it can hold integer values or be null.
        public int? StockId { get; set; }
    }
}