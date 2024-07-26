using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.netfarmework.Models
{
    public class BookAuthors
    {
        public int Id { get; set; }
        public virtual Book Book { get; set; }
        public virtual Authour Authour { get; set; }
    }
}
