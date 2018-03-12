using System.ComponentModel.DataAnnotations;

namespace HiEf21 {
    public class Student {
        [Key]
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public double Gpa { set; get; }
    }
}
