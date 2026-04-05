using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.DTOs;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class StudentController : ControllerBase
	{
		private readonly IStudentService _service;

		public StudentController(IStudentService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(await _service.GetAll());
		}

		[HttpPost]
		public async Task<IActionResult> Add(Student student)
		{
			await _service.Add(student);
			return Ok("Student Added");
		}

		[HttpPut]
		public async Task<IActionResult> Update(Student student)
		{
			await _service.Update(student);
			return Ok("Updated");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _service.Delete(id);
			return Ok("Deleted");
		}
	}
}
