using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;

namespace StudentManagementAPI.Services
{
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _repo;

		public StudentService(IStudentRepository repo)
		{
			_repo = repo;
		}

		public async Task<List<Student>> GetAll() => await _repo.GetAll();

		public async Task Add(Student student)
		{
			student.CreatedDate = DateTime.Now;
			await _repo.Add(student);
		}

		public async Task Update(Student student) => await _repo.Update(student);

		public async Task Delete(int id) => await _repo.Delete(id);
	}
}
