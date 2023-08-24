using System.ComponentModel.DataAnnotations;

namespace Çalışma1.Models
{
    public class Student// coklu
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? No { get; set; }

        public string Cinsiyet { get; set; }
        public int Yaş { get; set; }

        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

    }
}
