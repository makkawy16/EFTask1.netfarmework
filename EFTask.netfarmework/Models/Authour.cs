using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.netfarmework.Models
{
    public class Authour
    {
        public int AuthourId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<BookAuthors> BookAuthors { get; set; }

    }
}
