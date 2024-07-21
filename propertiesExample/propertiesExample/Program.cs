using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace propertiesExample
{
	public class person
	{
		public string name;
		public string address;

		public string getName()
		{
			return name;
		}
		public void setName(string n)
		{
			name = n;
		}
		public string getAddress()
		{
			return address;
		}
		public void setAddress(string n)
		{
			address = n;
		}

	}
	public class program
	{
		public static void main(string[]args)
		{
			person p = new person ();
			p.setName = "Aashish";
			p.setAdress="Itahari";
			Console.WriteLine ($"hello {p.setName}, you live in {p.getAddress}");
			Console.Readkey ();

		}

	}
}