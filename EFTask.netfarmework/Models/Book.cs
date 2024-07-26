using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.netfarmework.Models
{
    public class Book
    {
           public int Id {  get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PublisherYear {  get; set; }
        public virtual ICollection<BookAuthors> BookAuthors { get; set; }

        public override string ToString()
        {
            return $"id: {Id} , title : {Title} , publisher year : {PublisherYear}";
        }
    }
}
