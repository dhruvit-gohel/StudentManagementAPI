using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.DTOs
{
	public class StudentCreateDto
	{
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[Range(18, 60)]
		public int Age { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress]
		public string Email { get; set; }

		[Required(ErrorMessage = "Course is required")]
		public string Course { get; set; }
	}
}
