using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.API
{
	public class StudentsController : ApiController
	{
		public List<Student> Get()
		{
			return StudentRepository.GetAllStudents();
		}

		public HttpResponseMessage GetStudents()
		{
			HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, StudentRepository.GetAllStudents());
			response.Headers.Add("Access-Control-Allow-Origin", "*");
			return response;
		}

		public Student Get(int id)
		{
			return StudentRepository.GetStudent(id);
		}

		public void Post(Student Student)
		{
			StudentRepository.AddStudent(Student);
		}

		public void Put(Student Student)
		{
			StudentRepository.UpdateStudent(Student);
		}

		public void Delete(int id)
		{
			StudentRepository.RemoveStudent(id);
		}
	}
}