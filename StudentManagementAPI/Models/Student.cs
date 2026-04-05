using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
	public class Student
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress]
		public string Email { get; set; }
		[Range(18, 60)]
		public int Age { get; set; }
		[Required(ErrorMessage = "Course is required")]
		public string Course { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
