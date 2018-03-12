#load "Models.csx"
using System.Linq;

var range = Enumerable.Range(0, 10);
var context = GetContext();
foreach (var n in range) {
    var student = new Student {
        FirstName = $"FirstName {n}",
        LastName = $"LastName {n}",
        Gpa = n
    };
    context.Students.Add(student);
    context.SaveChanges();

    var course = new Course {
        StudentId = student.Id,
        Name = $"Corse {n}"
    };
    context.Courses.Add(course);
    context.SaveChanges();
}

Console.WriteLine(context.Students.Count());
Console.WriteLine(context.Courses.Count());