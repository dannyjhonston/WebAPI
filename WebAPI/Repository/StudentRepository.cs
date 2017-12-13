using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repository
{
	public class StudentRepository
	{
		private static List<Student> students = new List<Student> {
		new Student(){ StudentID=1, FirstName="Hass",LastName="Moh"},
		 new Student(){ StudentID=2, FirstName="Hassan",LastName="Mohemm"},
		  new Student(){ StudentID=3, FirstName="Hussan",LastName="Mohu"},
		   new Student(){ StudentID=4, FirstName="Hessan",LastName="Moham"}
	};

		public static List<Student> GetAllStudents()
		{
			return students;
		}

		public static Student GetStudent(int studentID)
		{
			return students.Where(d => d.StudentID == studentID).First();
		}

		public static void RemoveStudent(int studentID)
		{
			var stu = students.Find(s => s.StudentID == studentID);
			students.Remove(stu);
		}

		public static void AddStudent(Student student)
		{
			students.Add(student);
		}

		public static void UpdateStudent(Student student)
		{
			//
		}
	}
}