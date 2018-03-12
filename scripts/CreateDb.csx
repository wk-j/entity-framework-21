#load "Models.csx"

var context = GetContext();
context.Database.EnsureCreated();

var rs = context.Courses.ToList();
Console.WriteLine(rs.Count());
