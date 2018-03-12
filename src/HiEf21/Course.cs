using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiEf21 {
    public class Course {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }

        [ForeignKey("Student")]
        public int StudentId { set; get; }

        public Student Student { set; get; }
    }
}
