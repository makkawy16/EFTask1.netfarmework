using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.netfarmework.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Book book { get; set; }
        public Member member { get; set; }
    }
}
