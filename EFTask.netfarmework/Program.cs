using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.netfarmework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppContext context = new AppContext();

            var q = context.Books.Include(x=> x.BookAuthors).ToList();

            foreach (var x in q) {
                Console.WriteLine(x.Title);
                foreach (var item in x.BookAuthors)
                {
                    Console.WriteLine(item.Authour.Name);
                }
            }

            var q2 = context.members.Include(x => x.BorroedBook);

            foreach (var item in q2) {
                Console.WriteLine($"member name : {item.Name}");
                foreach (var item2 in item.BorroedBook)
                {
                    Console.WriteLine($"borrow id : {item2.BorrowId} , book title : {item2.book.Title}");
                }
            }

            var q3 = context.members.Include(x => x.BorroedBook);

            foreach (var item in q2)
            {
                Console.WriteLine($"member name : {item.Name}");
                Console.WriteLine($"number of book : {item.BorroedBook.Count}");
            }


            var q4 = context.Books.Where(x => x.PublisherYear > 2022);
            foreach (var item in q4) {
                Console.WriteLine(item);
            }


            var q5 = context.authours.Include(x => x.BookAuthors).ToList();

            foreach (var x in q5)
            {
                Console.WriteLine(x.Name);
                foreach (var item in x.BookAuthors)
                {
                    Console.WriteLine(item.Book.Title);
                }
            }

            var q6 = context.borrows.Include(x => x.book);
        
            foreach (var item in q6) {
                Console.WriteLine(item.book);
                
            }


            


            Console.ReadKey();
        }
    }
}
