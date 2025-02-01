using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweeftEFCodefirst.Models
{
    internal class SchoolModels
    {
        public class Teacher
        {
            [Required]
            [MaxLength(50)]
            [Key]
            public string TeacherID { get; set; }

            [Required]
            [MaxLength(100)]
            public string FirstName { get; set; }

            [Required]
            [MaxLength(100)]
            public string LastName { get; set; }

            [Required]
            [MaxLength(10)]
            public string Gender { get; set; }

            public ICollection<TeacherPupil> TeacherPupils { get; set; } = new List<TeacherPupil>();
        }

        public class Pupil
        {
            [Key]
            public int PupilID { get; set; }

            [Required]
            [MaxLength(100)]
            public string FirstName { get; set; }

            [Required]
            [MaxLength(100)]
            public string LastName { get; set; }

            [Required]
            [MaxLength(10)]
            public string Gender { get; set; }

            [Required]
            [MaxLength(20)]
            public string Class { get; set; }

            public ICollection<TeacherPupil> TeacherPupils { get; set; } = new List<TeacherPupil>();
        }

        public class TeacherPupil
        {
            [Required]
            public string TeacherId { get; set; }

            [ForeignKey("TeacherId")]
            public Teacher Teacher { get; set; }

            [Required]
            public int PupilId { get; set; }

            [ForeignKey("PupilId")]
            public Pupil Pupil { get; set; }
        }
    }
}
