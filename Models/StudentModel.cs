using System.ComponentModel.DataAnnotations;

namespace ERP_Demo_Core_MVC.Models
{
    public class StudentModel
    {
        [Key]
        public int Student_Roll { get; set; }

        [Required(ErrorMessage = "Enter Name Required")]
        public string Student_Name { get; set; }

        [Required(ErrorMessage = "Enter The Date Of Birth")]
        public DateOnly Student_DOB { get; set; }

        [Required(ErrorMessage ="Enter Valid Number")]
        [Range(0, 100)]
        public int Student_Age { get; set; }

        [Required]
        public string Student_Gender { get; set; }
    }
}