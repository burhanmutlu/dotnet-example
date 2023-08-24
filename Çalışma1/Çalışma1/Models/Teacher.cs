using System.ComponentModel.DataAnnotations;

namespace Çalışma1.Models
{
    public class Teacher //tekli
    {
        [Key]
        public  int Id { get; set; }
        public string name { get; set; }

        public IList<Student> Students { get; set; }
    }
}
