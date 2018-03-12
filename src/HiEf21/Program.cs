using System;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Linq;

namespace HiEf21 {


    class Program {
        static void Main(string[] args) {
            var connectionString = "Server=localhost;User Id=postgres; Password=1234";
            var context = new HiContext(connectionString);
            context.Database.EnsureCreated();

            var rs = context.Students.Where(x => x.Id > 0).ToList();
            Console.WriteLine(rs.Count);
        }
    }
}
