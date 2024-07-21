using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleCRUD.models


namespace consoleCRUD.Repository
{
	public static class studentRepo
	{
		private static List<student> stdList = new List<student> ();
		public static List<student> GetStudentList()
		{
			return stdList;
		}
		public static bool Addstudent(student s)
		{
			stdList.Add (s);
			return true;
		}
		public static bool DeleteStudent(string name)
		{
			student? student = stdList.where (s => s.Name.Equals (name)).FirstOrDefault();
			if (student != null)
			{
				stdList.Remove (student);
				return true;
			} 
			else
				return false;
		}
		public static bool updatestudent(int id, student s)
		{
			student? student=stdList.where(s=>s.Id==id).FirstOrDefault();
			if(student != null)
			{
				student.Name= s.Name;
				student.Address =s.Address;
				student.phone=s.phone;
				return true;
			}
			return false;
		}
	}
}