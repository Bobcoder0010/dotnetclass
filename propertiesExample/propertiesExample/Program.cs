using System;

namespace PropertiesExample
{
    public class Person
    {
        /* private string name;
         private string address;


         public string Name
         {
             get
             {
                 return name;
             }
             set
             {
                 if (value.Length > 1)
                 {
                     name = value;
                 }
                 else
                 {
                     name = "No Name";
                 }
             }
         }

         public string Address
         {
             get
             {
                 return address;
             }
             set
             {
                 if (value.Equals("Itahari") || value.Equals("Dharan") || value.Equals("Biratnagar"))
                 {
                     address = value;
                 }
                 else
                 {
                     Console.WriteLine("Invalid");
                     address = "Itahari";
                 }
             }
         }
     }
        */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public class Program
        {
            public static void Main(string[] args)
            {
                Person p = new Person();
                p.Name = "Roshan";
                p.Address = "a";
                p.Id = 1;
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Address);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
