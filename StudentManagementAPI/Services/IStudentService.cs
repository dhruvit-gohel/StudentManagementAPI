using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services
{
	public interface IStudentService
	{
		Task<List<Student>> GetAll();
		Task Add(Student student);
		Task Update(Student student);
		Task Delete(int id);
	}
}
