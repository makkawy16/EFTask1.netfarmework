using EFTask.netfarmework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.netfarmework
{
    public class AppContext : DbContext
    {
        private static readonly string serverName = @"MAKKAWY\SQLEXPRESS";
        private static readonly string databaseName = "EFTask";
        private static readonly string username = "makkawy";
        private static readonly string password = "123456";

        static string connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password}";


        public AppContext() : base(connectionString)
        {}

        public DbSet<Book> Books { get; set; }
        public DbSet<Authour> authours { get; set; }
        public DbSet<Borrow> borrows { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<BookAuthors> BookAuthors { get; set; }


    }
}
