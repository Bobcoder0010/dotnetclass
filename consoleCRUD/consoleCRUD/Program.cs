using System;

namespace consoleCRUD
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			do {
				console.clear ();
				console.Writeline ("select your choice:");
				console.Writeline ("1. Register new student:");
				console.Writeline ("2. Remove student :");
				console.Writeline ("3. Update student info:");
				console.Writeline ("4. List students:");
				console.Writeline ("5. Exit program :");
				char choice = Console.ReadKey ().KeyChar;
				switch (choice) {
				case '1':
					Insert ();
					break;
				case '2':
					Remove ();
					break;
				case '3':
					Update ();
					break;
				case '4':
					List ();
					break;
				case '5':
					exit ();
					return;
				}
				Console.ReadKey ();
			} while (true);
		}
		public static void Insert()
		{
			student newStd = new Student ();
			Console.WriteLine ();
			Console.WriteLine ("student Registration");
			Console.WriteLine ("Name:");
			newStd.Name = Console.ReadLine () ?? "No Name";
			Console.WriteLine ("Address:");
			newStd.Address = Console.ReadLine ()?? "No Address";
			Console.WriteLine ("Phone:");
			newStd.Phone = Console.ReadLine () ?? "No Phone";
			if (studentRepo.GetStudentList ().count > 0)
				newStd.Id = StudentRepo.GetStudentList ().Max (s => s.Id) + 1;
			else
				newStd.Id = 101;
		}
		public static void Remove()
		{
			Console.Writeline ();
			Console.WriteLine ("Remove Student");
			Console.WriteLine ("Name: ");
			string name = Console.ReadLine () ?? string.Empty;
			if (StudentRepo.DeleteStudent (name))
				Console.WriteLine ("Student removed");
			else
				Console.WriteLine ("Removal failed. Try again");
		}
		public static void Update()
		{
			Student s = new Student ();
			Console.WriteLine ("Update Student Information :");
			Console.WriteLine ("Enter Id of the student You want to modify :");
			s.Id = Convert.ToInt32 (Console.ReadLine ());
			conole.writeline ("New Name");
			s.Name = Console.ReadLine () ?? "No Name";
			console.Writeline ("New Address");
			s.Address = Console.ReadLine ()?? "No Address";
			Console.WriteLine ("Phone");
			s.Phone = Console.ReadLine () ?? "No Phone";
			if (studentRepo.updateStudent (s.Id, s))
				Console.WriteLine ("Update successfull.");
			else
				Console.WriteLine(


		}
		public static List()
		{
			console.WriteLine();
			console.WriteLine("List of students::");
			console.WriteLine("Id\tName of students\t\tAddress\t\tphone");
			foreach(Student s in StudentRepo.GetStudentList())
			{
				Console.WriteLine($"{
			}
		}


	}
}
