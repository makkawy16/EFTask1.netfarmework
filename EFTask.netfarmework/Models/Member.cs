using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.netfarmework.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime MemberShipDate { get; set; }
        public ICollection<Borrow> BorroedBook { get;set; }

        public override string ToString()
        {
            return $"{MemberId} , {Name} ";
        }
    }
}
