using System.ComponentModel.DataAnnotations;

namespace ERP_Demo_Core_MVC.Models
{
    public class TeacherModel
    {
        [Key]
        public int Teacher_Id { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Teacher_Name { get; set; }

        [Required(ErrorMessage = "Emial Required")]
        public string Teacher_Email { get; set; }

        [Required(ErrorMessage = " Phone Number Required")]
        public string Teacher_Phone { get; set; }

        [Required(ErrorMessage = "Gender Required")]
        public string Teacher_Gender { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Teacher_Address { get; set; }

        [Required(ErrorMessage = "Joining Date Required")]
        public DateOnly Teacher_Jion_Date { get; set; }
    }
}
