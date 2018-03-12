#! "netcoreapp2.0"
#r "nuget:NetStandard.Library,2.0.0"
#r "nuget:Microsoft.EntityFrameworkCore,2.1.0-preview1-final"
#r "nuget:Npgsql.EntityFrameworkCore.PostgreSQL,2.1.0-preview1"

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Student {
    [Key]
    public int Id { set; get; }
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public double Gpa { set; get; }
}

public class Course {
    [Key]
    public int Id { set; get; }
    public string Name { set; get; }

    [ForeignKey("Student")]
    public int StudentId { set; get; }

    public Student Student { set; get; }
}

public class HiContext : DbContext {
    private string connectionString;
    public HiContext(string connectionString) => this.connectionString = connectionString;
    protected override void OnConfiguring(DbContextOptionsBuilder builder) {
        builder.UseNpgsql(connectionString);
    }
    public DbSet<Student> Students { set; get; }
    public DbSet<Course> Courses { set; get; }
}

public HiContext GetContext() {
    var connectionString = "Server=localhost;User Id=postgres;Password=1234;Database=EntityFrameworkCore21";
    var context = new HiContext(connectionString);
    return context;
}